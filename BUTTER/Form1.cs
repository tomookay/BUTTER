using System;
using System.Windows.Forms;

namespace BUTTER
{
    public partial class Form1 : Form
    {
        private bool _isUpdating = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sync labels for station1 and ensure each station sums to 100 at startup
            lblEasyVal.Text = tbEasy.Value.ToString();
            lblMediumVal.Text = tbMedium.Value.ToString();
            lblHardVal.Text = tbHard.Value.ToString();

            KeepTotalAt100(tbEasy, tbMedium, tbHard, lblEasyVal, lblMediumVal, lblHardVal);

            // For stations 2..6, call the KeepTotalAt100 with the designer-created controls
            KeepTotalAt100(tbEasy2, tbMedium2, tbHard2, lblEasyVal2, lblMediumVal2, lblHardVal2);
            KeepTotalAt100(tbEasy3, tbMedium3, tbHard3, lblEasyVal3, lblMediumVal3, lblHardVal3);
            KeepTotalAt100(tbEasy4, tbMedium4, tbHard4, lblEasyVal4, lblMediumVal4, lblHardVal4);
            KeepTotalAt100(tbEasy5, tbMedium5, tbHard5, lblEasyVal5, lblMediumVal5, lblHardVal5);
            KeepTotalAt100(tbEasy6, tbMedium6, tbHard6, lblEasyVal6, lblMediumVal6, lblHardVal6);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        // Station1 handlers
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal.Text = tbEasy.Value.ToString();
            KeepTotalAt100(tbEasy, tbMedium, tbHard, lblEasyVal, lblMediumVal, lblHardVal);
        }

        private void tbMedium_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal.Text = tbMedium.Value.ToString();
            KeepTotalAt100(tbMedium, tbEasy, tbHard, lblMediumVal, lblEasyVal, lblHardVal);
        }

        private void tbHard_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal.Text = tbHard.Value.ToString();
            KeepTotalAt100(tbHard, tbEasy, tbMedium, lblHardVal, lblEasyVal, lblMediumVal);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblEasyVal_Click(object sender, EventArgs e)
        {
        }

        private void lblEasyVal_TextChanged(object sender, EventArgs e)
        {
        }

        // -------------------------
        // Station2 handlers
        // -------------------------
        private void tbEasy2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal2.Text = tbEasy2.Value.ToString();
            KeepTotalAt100(tbEasy2, tbMedium2, tbHard2, lblEasyVal2, lblMediumVal2, lblHardVal2);
        }

        private void tbMedium2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal2.Text = tbMedium2.Value.ToString();
            KeepTotalAt100(tbMedium2, tbEasy2, tbHard2, lblMediumVal2, lblEasyVal2, lblHardVal2);
        }

        private void tbHard2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal2.Text = tbHard2.Value.ToString();
            KeepTotalAt100(tbHard2, tbEasy2, tbMedium2, lblHardVal2, lblEasyVal2, lblMediumVal2);
        }

        // -------------------------
        // Station3 handlers
        // -------------------------
        private void tbEasy3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal3.Text = tbEasy3.Value.ToString();
            KeepTotalAt100(tbEasy3, tbMedium3, tbHard3, lblEasyVal3, lblMediumVal3, lblHardVal3);
        }

        private void tbMedium3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal3.Text = tbMedium3.Value.ToString();
            KeepTotalAt100(tbMedium3, tbEasy3, tbHard3, lblMediumVal3, lblEasyVal3, lblHardVal3);
        }

        private void tbHard3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal3.Text = tbHard3.Value.ToString();
            KeepTotalAt100(tbHard3, tbEasy3, tbMedium3, lblHardVal3, lblEasyVal3, lblMediumVal3);
        }

        // -------------------------
        // Station4 handlers
        // -------------------------
        private void tbEasy4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal4.Text = tbEasy4.Value.ToString();
            KeepTotalAt100(tbEasy4, tbMedium4, tbHard4, lblEasyVal4, lblMediumVal4, lblHardVal4);
        }

        private void tbMedium4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal4.Text = tbMedium4.Value.ToString();
            KeepTotalAt100(tbMedium4, tbEasy4, tbHard4, lblMediumVal4, lblEasyVal4, lblHardVal4);
        }

        private void tbHard4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal4.Text = tbHard4.Value.ToString();
            KeepTotalAt100(tbHard4, tbEasy4, tbMedium4, lblHardVal4, lblEasyVal4, lblMediumVal4);
        }

        // -------------------------
        // Station5 handlers
        // -------------------------
        private void tbEasy5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal5.Text = tbEasy5.Value.ToString();
            KeepTotalAt100(tbEasy5, tbMedium5, tbHard5, lblEasyVal5, lblMediumVal5, lblHardVal5);
        }

        private void tbMedium5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal5.Text = tbMedium5.Value.ToString();
            KeepTotalAt100(tbMedium5, tbEasy5, tbHard5, lblMediumVal5, lblEasyVal5, lblHardVal5);
        }

        private void tbHard5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal5.Text = tbHard5.Value.ToString();
            KeepTotalAt100(tbHard5, tbEasy5, tbMedium5, lblHardVal5, lblEasyVal5, lblMediumVal5);
        }

        // -------------------------
        // Station6 handlers
        // -------------------------
        private void tbEasy6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal6.Text = tbEasy6.Value.ToString();
            KeepTotalAt100(tbEasy6, tbMedium6, tbHard6, lblEasyVal6, lblMediumVal6, lblHardVal6);
        }

        private void tbMedium6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal6.Text = tbMedium6.Value.ToString();
            KeepTotalAt100(tbMedium6, tbEasy6, tbHard6, lblMediumVal6, lblEasyVal6, lblHardVal6);
        }

        private void tbHard6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal6.Text = tbHard6.Value.ToString();
            KeepTotalAt100(tbHard6, tbEasy6, tbMedium6, lblHardVal6, lblEasyVal6, lblMediumVal6);
        }

        /// <summary>
        /// Generic keeper: Adjust other1/other2 so the three trackbars sum to 100.
        /// If others cannot absorb delta, the changed trackbar will be clamped so total remains 100.
        /// </summary>
        private void KeepTotalAt100(TrackBar changed, TrackBar other1, TrackBar other2,
            Label changedLbl, Label other1Lbl, Label other2Lbl)
        {
            _isUpdating = true;
            try
            {
                int total = changed.Value + other1.Value + other2.Value;
                if (total == 100)
                {
                    // update labels and exit
                    changedLbl.Text = changed.Value.ToString();
                    other1Lbl.Text = other1.Value.ToString();
                    other2Lbl.Text = other2.Value.ToString();
                    return;
                }

                int delta = 100 - total; // amount to distribute (can be negative)

                // Prefer adjusting the larger other first
                var first = other1.Value >= other2.Value ? other1 : other2;
                var second = first == other1 ? other2 : other1;

                int remaining = delta;

                // apply to first
                int newFirst = Clamp(first.Value + remaining, 0, 100);
                int appliedFirst = newFirst - first.Value;
                first.Value = newFirst;
                remaining -= appliedFirst;

                // apply to second
                int newSecond = Clamp(second.Value + remaining, 0, 100);
                int appliedSecond = newSecond - second.Value;
                second.Value = newSecond;
                remaining -= appliedSecond;

                // if still remaining, clamp changed
                if (remaining != 0)
                {
                    int newChanged = Clamp(changed.Value + remaining, 0, 100);
                    int appliedChanged = newChanged - changed.Value;
                    changed.Value = newChanged;
                    remaining -= appliedChanged;
                }

                // Update labels
                changedLbl.Text = changed.Value.ToString();
                other1Lbl.Text = other1.Value.ToString();
                other2Lbl.Text = other2.Value.ToString();
            }
            finally
            {
                _isUpdating = false;
            }
        }

        private int Clamp(int v, int min, int max) => Math.Min(Math.Max(v, min), max);
    }
}
