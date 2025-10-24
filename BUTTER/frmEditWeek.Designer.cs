namespace BUTTER
{
    partial class frmEditWeek
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
            nudTuesday = new NumericUpDown();
            nudWednesday = new NumericUpDown();
            nudThursday = new NumericUpDown();
            nudFriday = new NumericUpDown();
            nudSaturday = new NumericUpDown();
            nudSunday = new NumericUpDown();
            lblMonday = new Label();
            lblTuesday = new Label();
            lblWednesday = new Label();
            lblThursday = new Label();
            lblFriday = new Label();
            lblSaturday = new Label();
            lblSunday = new Label();
            nudMonday = new NumericUpDown();
            lblTotalHours = new Label();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTuesday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWednesday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThursday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFriday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaturday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSunday).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMonday).BeginInit();
            SuspendLayout();
            // 
            // nudTuesday
            // 
            nudTuesday.DecimalPlaces = 1;
            nudTuesday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudTuesday.Location = new Point(86, 12);
            nudTuesday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudTuesday.Name = "nudTuesday";
            nudTuesday.Size = new Size(68, 23);
            nudTuesday.TabIndex = 9;
            nudTuesday.TextAlign = HorizontalAlignment.Center;
            nudTuesday.Value = new decimal(new int[] { 8, 0, 0, 0 });
            nudTuesday.ValueChanged += nudTuesday_ValueChanged;
            // 
            // nudWednesday
            // 
            nudWednesday.DecimalPlaces = 1;
            nudWednesday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudWednesday.Location = new Point(165, 12);
            nudWednesday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudWednesday.Name = "nudWednesday";
            nudWednesday.Size = new Size(68, 23);
            nudWednesday.TabIndex = 10;
            nudWednesday.TextAlign = HorizontalAlignment.Center;
            nudWednesday.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // nudThursday
            // 
            nudThursday.DecimalPlaces = 1;
            nudThursday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudThursday.Location = new Point(251, 12);
            nudThursday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudThursday.Name = "nudThursday";
            nudThursday.Size = new Size(68, 23);
            nudThursday.TabIndex = 11;
            nudThursday.TextAlign = HorizontalAlignment.Center;
            nudThursday.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // nudFriday
            // 
            nudFriday.DecimalPlaces = 1;
            nudFriday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudFriday.Location = new Point(325, 12);
            nudFriday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudFriday.Name = "nudFriday";
            nudFriday.Size = new Size(68, 23);
            nudFriday.TabIndex = 12;
            nudFriday.TextAlign = HorizontalAlignment.Center;
            nudFriday.Value = new decimal(new int[] { 55, 0, 0, 65536 });
            // 
            // nudSaturday
            // 
            nudSaturday.DecimalPlaces = 1;
            nudSaturday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudSaturday.Location = new Point(400, 12);
            nudSaturday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudSaturday.Name = "nudSaturday";
            nudSaturday.Size = new Size(68, 23);
            nudSaturday.TabIndex = 13;
            nudSaturday.TextAlign = HorizontalAlignment.Center;
            nudSaturday.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // nudSunday
            // 
            nudSunday.DecimalPlaces = 1;
            nudSunday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudSunday.Location = new Point(474, 12);
            nudSunday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudSunday.Name = "nudSunday";
            nudSunday.Size = new Size(68, 23);
            nudSunday.TabIndex = 14;
            nudSunday.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMonday
            // 
            lblMonday.Location = new Point(12, 38);
            lblMonday.Name = "lblMonday";
            lblMonday.Size = new Size(68, 15);
            lblMonday.TabIndex = 0;
            lblMonday.Text = "Monday";
            lblMonday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            lblTuesday.Location = new Point(86, 38);
            lblTuesday.Name = "lblTuesday";
            lblTuesday.Size = new Size(68, 15);
            lblTuesday.TabIndex = 1;
            lblTuesday.Text = "Tuesday";
            lblTuesday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            lblWednesday.Location = new Point(165, 38);
            lblWednesday.Name = "lblWednesday";
            lblWednesday.Size = new Size(68, 15);
            lblWednesday.TabIndex = 2;
            lblWednesday.Text = "Wednesday";
            lblWednesday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            lblThursday.Location = new Point(251, 38);
            lblThursday.Name = "lblThursday";
            lblThursday.Size = new Size(68, 15);
            lblThursday.TabIndex = 3;
            lblThursday.Text = "Thursday";
            lblThursday.TextAlign = ContentAlignment.MiddleCenter;
            lblThursday.Click += lblThursday_Click;
            // 
            // lblFriday
            // 
            lblFriday.Location = new Point(326, 38);
            lblFriday.Name = "lblFriday";
            lblFriday.Size = new Size(68, 15);
            lblFriday.TabIndex = 4;
            lblFriday.Text = "Friday";
            lblFriday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSaturday
            // 
            lblSaturday.Location = new Point(400, 38);
            lblSaturday.Name = "lblSaturday";
            lblSaturday.Size = new Size(68, 15);
            lblSaturday.TabIndex = 5;
            lblSaturday.Text = "Saturday";
            lblSaturday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSunday
            // 
            lblSunday.Location = new Point(475, 38);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(68, 15);
            lblSunday.TabIndex = 6;
            lblSunday.Text = "Sunday";
            lblSunday.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudMonday
            // 
            nudMonday.DecimalPlaces = 1;
            nudMonday.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudMonday.Location = new Point(12, 12);
            nudMonday.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nudMonday.Name = "nudMonday";
            nudMonday.Size = new Size(68, 23);
            nudMonday.TabIndex = 8;
            nudMonday.TextAlign = HorizontalAlignment.Center;
            nudMonday.Value = new decimal(new int[] { 8, 0, 0, 0 });
            nudMonday.ValueChanged += nudMonday_ValueChanged;
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.Location = new Point(580, 14);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(13, 15);
            lblTotalHours.TabIndex = 15;
            lblTotalHours.Text = "0";
            lblTotalHours.TextChanged += lblTotalHours_Changed;
            lblTotalHours.Click += lblTotalHours_Click;
            // 
            // button1
            // 
            button1.Location = new Point(731, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 14);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 17;
            label1.Text = "Hours / Week";
            // 
            // frmEditWeek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 69);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblTotalHours);
            Controls.Add(nudSunday);
            Controls.Add(nudSaturday);
            Controls.Add(nudFriday);
            Controls.Add(nudThursday);
            Controls.Add(nudWednesday);
            Controls.Add(nudTuesday);
            Controls.Add(nudMonday);
            Controls.Add(lblSunday);
            Controls.Add(lblSaturday);
            Controls.Add(lblFriday);
            Controls.Add(lblThursday);
            Controls.Add(lblWednesday);
            Controls.Add(lblTuesday);
            Controls.Add(lblMonday);
            Name = "frmEditWeek";
            Text = "Edit Week";
            Load += frmEditWeek_Load;
            ((System.ComponentModel.ISupportInitialize)nudTuesday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWednesday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThursday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFriday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaturday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSunday).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMonday).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown nudTuesday;
        private NumericUpDown nudWednesday;
        private NumericUpDown nudThursday;
        private NumericUpDown nudFriday;
        private NumericUpDown nudSaturday;
        private NumericUpDown nudSunday;
        private Label lblMonday;
        private Label lblTuesday;
        private Label lblWednesday;
        private Label lblThursday;
        private Label lblFriday;
        private Label lblSaturday;
        private Label lblSunday;
        private NumericUpDown nudMonday;
        private Label lblTotalHours;
        private Button button1;
        private Label label1;
    }
}