namespace BUTTER
{
    partial class dialogMotionEntry
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
            btnOrderReturn = new Button();
            btnOrderAdvance = new Button();
            txbReturned = new TextBox();
            txbReturn = new TextBox();
            txbMotionName = new TextBox();
            txbAdvanced = new TextBox();
            txbAdvance = new TextBox();
            SuspendLayout();
            // 
            // btnOrderReturn
            // 
            btnOrderReturn.Location = new Point(411, 12);
            btnOrderReturn.Name = "btnOrderReturn";
            btnOrderReturn.Size = new Size(75, 53);
            btnOrderReturn.TabIndex = 14;
            btnOrderReturn.Text = "2";
            btnOrderReturn.UseVisualStyleBackColor = true;
            // 
            // btnOrderAdvance
            // 
            btnOrderAdvance.Location = new Point(12, 12);
            btnOrderAdvance.Name = "btnOrderAdvance";
            btnOrderAdvance.Size = new Size(75, 53);
            btnOrderAdvance.TabIndex = 13;
            btnOrderAdvance.Text = "1";
            btnOrderAdvance.UseVisualStyleBackColor = true;
            // 
            // txbReturned
            // 
            txbReturned.Location = new Point(305, 42);
            txbReturned.Name = "txbReturned";
            txbReturned.Size = new Size(100, 23);
            txbReturned.TabIndex = 12;
            txbReturned.Text = "Returned";
            txbReturned.TextAlign = HorizontalAlignment.Right;
            // 
            // txbReturn
            // 
            txbReturn.Location = new Point(305, 13);
            txbReturn.Name = "txbReturn";
            txbReturn.Size = new Size(100, 23);
            txbReturn.TabIndex = 11;
            txbReturn.Text = "Return";
            txbReturn.TextAlign = HorizontalAlignment.Right;
            // 
            // txbMotionName
            // 
            txbMotionName.Location = new Point(199, 13);
            txbMotionName.Name = "txbMotionName";
            txbMotionName.Size = new Size(100, 23);
            txbMotionName.TabIndex = 10;
            txbMotionName.Text = "Motion Name";
            txbMotionName.TextAlign = HorizontalAlignment.Center;
            // 
            // txbAdvanced
            // 
            txbAdvanced.Location = new Point(93, 42);
            txbAdvanced.Name = "txbAdvanced";
            txbAdvanced.Size = new Size(100, 23);
            txbAdvanced.TabIndex = 9;
            txbAdvanced.Text = "Advanced";
            // 
            // txbAdvance
            // 
            txbAdvance.Location = new Point(93, 13);
            txbAdvance.Name = "txbAdvance";
            txbAdvance.Size = new Size(100, 23);
            txbAdvance.TabIndex = 8;
            txbAdvance.Text = "Advance";
            // 
            // dialogMotionEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 76);
            Controls.Add(btnOrderReturn);
            Controls.Add(btnOrderAdvance);
            Controls.Add(txbReturned);
            Controls.Add(txbReturn);
            Controls.Add(txbMotionName);
            Controls.Add(txbAdvanced);
            Controls.Add(txbAdvance);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "dialogMotionEntry";
            Text = "dialogMotionEntry";
            Load += dialogMotionEntry_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrderReturn;
        private Button btnOrderAdvance;
        private TextBox txbReturned;
        private TextBox txbReturn;
        private TextBox txbMotionName;
        private TextBox txbAdvanced;
        private TextBox txbAdvance;
    }
}