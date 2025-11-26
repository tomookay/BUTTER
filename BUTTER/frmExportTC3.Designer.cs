namespace BUTTER
{
    partial class frmExportTC3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            tsLblTC3Path = new ToolStripStatusLabel();
            grpbxStation1 = new GroupBox();
            listBoxStation1Motions = new ListBox();
            OpenTC3Solution = new OpenFileDialog();
            txbFileContents = new TextBox();
            statusStrip1.SuspendLayout();
            grpbxStation1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsLblTC3Path });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsLblTC3Path
            // 
            tsLblTC3Path.Name = "tsLblTC3Path";
            tsLblTC3Path.Size = new Size(160, 17);
            tsLblTC3Path.Text = "No TwinCAT3 Solution Path...";
            // 
            // grpbxStation1
            // 
            grpbxStation1.Controls.Add(listBoxStation1Motions);
            grpbxStation1.Location = new Point(12, 12);
            grpbxStation1.Name = "grpbxStation1";
            grpbxStation1.Size = new Size(740, 196);
            grpbxStation1.TabIndex = 1;
            grpbxStation1.TabStop = false;
            grpbxStation1.Text = "Station 1";
            // 
            // listBoxStation1Motions
            // 
            listBoxStation1Motions.FormattingEnabled = true;
            listBoxStation1Motions.Location = new Point(6, 22);
            listBoxStation1Motions.Name = "listBoxStation1Motions";
            listBoxStation1Motions.ScrollAlwaysVisible = true;
            listBoxStation1Motions.Size = new Size(699, 139);
            listBoxStation1Motions.TabIndex = 0;
            listBoxStation1Motions.SelectedIndexChanged += listBoxStation1Motions_SelectedIndexChanged;
            // 
            // OpenTC3Solution
            // 
            OpenTC3Solution.FileName = "Select TwinCAT3 Solution";
            OpenTC3Solution.Filter = "TwinCAT3 Solution files|*.sln";
            OpenTC3Solution.Title = "Select TwinCAT3 Solution";
            // 
            // txbFileContents
            // 
            txbFileContents.Location = new Point(18, 214);
            txbFileContents.Multiline = true;
            txbFileContents.Name = "txbFileContents";
            txbFileContents.Size = new Size(699, 201);
            txbFileContents.TabIndex = 2;
            // 
            // frmExportTC3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbFileContents);
            Controls.Add(grpbxStation1);
            Controls.Add(statusStrip1);
            Name = "frmExportTC3";
            Text = "frmExportTC3";
            Load += frmExportTC3_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpbxStation1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsLblTC3Path;
        private GroupBox grpbxStation1;
        private ListBox listBoxStation1Motions;
        private OpenFileDialog OpenTC3Solution;
        private TextBox txbFileContents;
    }
}