using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUTTER
{
    public partial class frmEditWeek : Form
    {
        public frmEditWeek()
        {
            InitializeComponent();
        }

        private void frmEditWeek_Load(object sender, EventArgs e)
        {
            // Attach a single ValueChanged handler to all NumericUpDown controls (including nested ones).
            foreach (var nud in GetAllControls(this).OfType<NumericUpDown>())
            {
                // ensure we don't attach multiple times in case Load is called again
                nud.ValueChanged -= AnyNud_ValueChanged;
                nud.ValueChanged += AnyNud_ValueChanged;
            }

            // initialize total display
            UpdateTotalHours();
        }

        // common handler for any NumericUpDown value change
        private void AnyNud_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalHours();
        }

        // recursively enumerate all child controls
        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                yield return c;
                foreach (var child in GetAllControls(c))
                    yield return child;
            }
        }

        // sums all NumericUpDown.Value values and writes to lblTotalHours.Text
        private void UpdateTotalHours()
        {
            decimal total = 0m;
            foreach (var nud in GetAllControls(this).OfType<NumericUpDown>())
            {
                total += nud.Value;
            }

            // format as number (no trailing zeros) — adjust format as needed
            lblTotalHours.Text = total.ToString("0.##");
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            // kept for Designer-wired event compatibility
            UpdateTotalHours();
        }

        private void lblThursday_Click(object sender, EventArgs e)
        {

        }

        private void nudTuesday_ValueChanged(object sender, EventArgs e)
        {
            // kept for Designer-wired event compatibility
            UpdateTotalHours();
        }

        private void nudMonday_ValueChanged(object sender, EventArgs e)
        {
            // kept for Designer-wired event compatibility
            UpdateTotalHours();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
