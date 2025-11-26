using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BUTTER
{
    public partial class frmExportTC3 : Form
    {
        public frmExportTC3()
        {
            InitializeComponent();
        }

        private void frmExportTC3_Load(object sender, EventArgs e)
        {
            string tc3path;
            OpenTC3Solution.ShowDialog();

            tc3path = OpenTC3Solution.FileName;
            if (string.IsNullOrWhiteSpace(tc3path))
            {
                MessageBox.Show("No TwinCAT 3 project path selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tsLblTC3Path.Text = tc3path;
            }

            // Determine the directory to search. If a file was picked, use its containing directory.
            string searchDir = tc3path;
            if (File.Exists(tc3path))
                searchDir = Path.GetDirectoryName(tc3path) ?? tc3path;

            if (!Directory.Exists(searchDir))
            {
                MessageBox.Show("The selected path does not contain a valid directory to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Populate listBoxStation1Motions with full file paths of all .TcPOU files found (recursive)
            // but only include files that are contained in folders named "Station 1" .. "Station 6".
            listBoxStation1Motions.Items.Clear();
            try
            {
                var tcPouFiles = Directory.EnumerateFiles(searchDir, "*.TcPOU", SearchOption.AllDirectories);

                // Allowed station folder names
                var allowedStations = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "Station 1",
                    "Station 2",
                    "Station 3",
                    "Station 4",
                    "Station 5",
                    "Station 6"
                };

                // Filter to files that have one of the allowed station folder names in their ancestor path
                var filteredFiles = tcPouFiles.Where(file =>
                {
                    string dir = Path.GetDirectoryName(file);
                    while (!string.IsNullOrEmpty(dir))
                    {
                        string folderName = Path.GetFileName(dir);
                        if (allowedStations.Contains(folderName))
                            return true;
                        dir = Path.GetDirectoryName(dir);
                    }
                    return false;
                }).ToList();

                if (filteredFiles.Count == 0)
                {
                    MessageBox.Show("No .TcPOU files found under the selected path within 'Station 1'..'Station 6' folders.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                listBoxStation1Motions.BeginUpdate();
                try
                {
                    foreach (var file in filteredFiles)
                    {
                        // Add the full file path as a single ListBox item
                        listBoxStation1Motions.Items.Add(file);
                    }
                }
                finally
                {
                    listBoxStation1Motions.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for .TcPOU files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxStation1Motions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item as a file path
            if (listBoxStation1Motions.SelectedItem is not string filePath || string.IsNullOrWhiteSpace(filePath))
            {
                // No valid selection — clear the display
                txbFileContents.Clear();
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFileContents.Clear();
                return;
            }

            try
            {
                // Show wait cursor for large files
                Cursor previousCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    // Read and display the file contents
                    string content = File.ReadAllText(filePath);
                    txbFileContents.Text = content;
                }
                finally
                {
                    Cursor.Current = previousCursor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbFileContents.Clear();
            }
        }
    }
}
