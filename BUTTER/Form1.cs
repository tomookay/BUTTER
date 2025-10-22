using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Forms;

namespace BUTTER
{
    public partial class Form1 : Form
    {
        private bool _isUpdating = false;
        //text data for all stations
        MotionRow[] Station1Rows = new MotionRow[99];
        MotionRow[] Station2Rows = new MotionRow[99];
        MotionRow[] Station3Rows = new MotionRow[99];
        MotionRow[] Station4Rows = new MotionRow[99];
        MotionRow[] Station5Rows = new MotionRow[99];
        MotionRow[] Station6Rows = new MotionRow[99];

        public Form1()
        {
            InitializeComponent();

            // Wire the checkbox event here so the handler works without modifying the Designer file.
            if (cboxStandard1 != null)
                cboxStandard1.CheckedChanged += cboxStandard_CheckedChanged;

            if (cboxStandard2 != null)
                cboxStandard2.CheckedChanged += cboxStandard_CheckedChanged;

            if (cboxStandard3 != null)
                cboxStandard3.CheckedChanged += cboxStandard_CheckedChanged;

            if (cboxStandard4 != null)
                cboxStandard4.CheckedChanged += cboxStandard_CheckedChanged;

            if (cboxStandard5 != null)
                cboxStandard5.CheckedChanged += cboxStandard_CheckedChanged;

            if (cboxStandard6 != null)
                cboxStandard6.CheckedChanged += cboxStandard_CheckedChanged;

        }

        // New generic handler for all station "standard" checkboxes (1..6)
        private void cboxStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not CheckBox cb) return;

            int station = cb.Name switch
            {
                "cboxStandard1" => 1,
                "cboxStandard2" => 2,
                "cboxStandard3" => 3,
                "cboxStandard4" => 4,
                "cboxStandard5" => 5,
                "cboxStandard6" => 6,
                _ => 0
            };
            if (station == 0) return;

            ApplyStandardToStation(station, cb.Checked);
        }

        // Apply or remove the "standard" preset for a given station number (1..6)
        private void ApplyStandardToStation(int station, bool applyStandard)
        {
            switch (station)
            {
                //i have no idea why the AI wanted to do it this way, but it works... 
                case 1:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask1, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask1, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask1, 8.0m);

                        SetTrackBarValueSafe(tbEasy1, 75);
                        SetTrackBarValueSafe(tbMedium1, 15);
                        SetTrackBarValueSafe(tbHard1, 10);
                    }
                    else
                    {
                        // Re-enable the NumericUpDowns and TrackBars for manual editing
                        nudEasyHoursTask1.Enabled = true;
                        nudMediumHoursTask1.Enabled = true;
                        nudHardHoursTask1.Enabled = true;
                        tbEasy1.Enabled = true;
                        tbMedium1.Enabled = true;
                        tbHard1.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1,
                        nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);

                    KeepTotalAt100(tbEasy1, tbMedium1, tbHard1, lblEasyVal, lblMediumVal, lblHardVal);
                    break;

                case 2:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask2, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask2, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask2, 8.0m);

                        SetTrackBarValueSafe(tbEasy2, 75);
                        SetTrackBarValueSafe(tbMedium2, 15);
                        SetTrackBarValueSafe(tbHard2, 10);
                    }
                    else
                    {
                        nudEasyHoursTask2.Enabled = true;
                        nudMediumHoursTask2.Enabled = true;
                        nudHardHoursTask2.Enabled = true;
                        tbEasy2.Enabled = true;
                        tbMedium2.Enabled = true;
                        tbHard2.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2,
                        nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);

                    KeepTotalAt100(tbEasy2, tbMedium2, tbHard2, lblEasyVal2, lblMediumVal2, lblHardVal2);
                    break;

                case 3:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask3, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask3, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask3, 8.0m);

                        SetTrackBarValueSafe(tbEasy3, 75);
                        SetTrackBarValueSafe(tbMedium3, 15);
                        SetTrackBarValueSafe(tbHard3, 10);
                    }
                    else
                    {
                        nudEasyHoursTask3.Enabled = true;
                        nudMediumHoursTask3.Enabled = true;
                        nudHardHoursTask3.Enabled = true;
                        tbEasy3.Enabled = true;
                        tbMedium3.Enabled = true;
                        tbHard3.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3,
                        nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);

                    KeepTotalAt100(tbEasy3, tbMedium3, tbHard3, lblEasyVal3, lblMediumVal3, lblHardVal3);
                    break;

                case 4:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask4, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask4, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask4, 8.0m);

                        SetTrackBarValueSafe(tbEasy4, 75);
                        SetTrackBarValueSafe(tbMedium4, 15);
                        SetTrackBarValueSafe(tbHard4, 10);
                    }
                    else
                    {
                        nudEasyHoursTask4.Enabled = true;
                        nudMediumHoursTask4.Enabled = true;
                        nudHardHoursTask4.Enabled = true;
                        tbEasy4.Enabled = true;
                        tbMedium4.Enabled = true;
                        tbHard4.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4,
                        nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);

                    KeepTotalAt100(tbEasy4, tbMedium4, tbHard4, lblEasyVal4, lblMediumVal4, lblHardVal4);
                    break;

                case 5:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask5, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask5, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask5, 8.0m);

                        SetTrackBarValueSafe(tbEasy5, 75);
                        SetTrackBarValueSafe(tbMedium5, 15);
                        SetTrackBarValueSafe(tbHard5, 10);
                    }
                    else
                    {
                        nudEasyHoursTask5.Enabled = true;
                        nudMediumHoursTask5.Enabled = true;
                        nudHardHoursTask5.Enabled = true;
                        tbEasy5.Enabled = true;
                        tbMedium5.Enabled = true;
                        tbHard5.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5,
                        nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);

                    KeepTotalAt100(tbEasy5, tbMedium5, tbHard5, lblEasyVal5, lblMediumVal5, lblHardVal5);
                    break;

                case 6:
                    if (applyStandard)
                    {
                        SetNumericUpDownValueSafe(nudEasyHoursTask6, 1.0m);
                        SetNumericUpDownValueSafe(nudMediumHoursTask6, 3.0m);
                        SetNumericUpDownValueSafe(nudHardHoursTask6, 8.0m);

                        SetTrackBarValueSafe(tbEasy6, 75);
                        SetTrackBarValueSafe(tbMedium6, 15);
                        SetTrackBarValueSafe(tbHard6, 10);
                    }
                    else
                    {
                        nudEasyHoursTask6.Enabled = true;
                        nudMediumHoursTask6.Enabled = true;
                        nudHardHoursTask6.Enabled = true;
                        tbEasy6.Enabled = true;
                        tbMedium6.Enabled = true;
                        tbHard6.Enabled = true;
                    }

                    UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6,
                        nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);

                    KeepTotalAt100(tbEasy6, tbMedium6, tbHard6, lblEasyVal6, lblMediumVal6, lblHardVal6);
                    break;
            }

            // Always refresh overall total after any station change
            UpdateTotalHours();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sync labels for station1 and ensure each station sums to 100 at startup
            lblEasyVal.Text = tbEasy1.Value.ToString();
            lblMediumVal.Text = tbMedium1.Value.ToString();
            lblHardVal.Text = tbHard1.Value.ToString();

            KeepTotalAt100(tbEasy1, tbMedium1, tbHard1, lblEasyVal, lblMediumVal, lblHardVal);

            // Ensure each station sums to 100 and compute initial hours
            KeepTotalAt100(tbEasy2, tbMedium2, tbHard2, lblEasyVal2, lblMediumVal2, lblHardVal2);
            KeepTotalAt100(tbEasy3, tbMedium3, tbHard3, lblEasyVal3, lblMediumVal3, lblHardVal3);
            KeepTotalAt100(tbEasy4, tbMedium4, tbHard4, lblEasyVal4, lblMediumVal4, lblHardVal4);
            KeepTotalAt100(tbEasy5, tbMedium5, tbHard5, lblEasyVal5, lblMediumVal5, lblHardVal5);
            KeepTotalAt100(tbEasy6, tbMedium6, tbHard6, lblEasyVal6, lblMediumVal6, lblHardVal6);

            // Compute hours for all stations (station1 uses numericUpDown1 & numericUpDown4/5/6)
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);

            // Ensure total is computed at startup
            UpdateTotalHours();

            //disable hours setting
            nudEasyHoursTask1.Enabled = false;
            nudMediumHoursTask1.Enabled = false;
            nudHardHoursTask1.Enabled = false;
            tbEasy1.Enabled = false;
            tbMedium1.Enabled = false;
            tbHard1.Enabled = false;

            nudEasyHoursTask2.Enabled = false;
            nudMediumHoursTask2.Enabled = false;
            nudHardHoursTask2.Enabled = false;
            tbEasy2.Enabled = false;
            tbMedium2.Enabled = false;
            tbHard2.Enabled = false;

            nudEasyHoursTask3.Enabled = false;
            nudMediumHoursTask3.Enabled = false;
            nudHardHoursTask3.Enabled = false;
            tbEasy3.Enabled = false;
            tbMedium3.Enabled = false;
            tbHard3.Enabled = false;

            nudEasyHoursTask4.Enabled = false;
            nudMediumHoursTask4.Enabled = false;
            nudHardHoursTask4.Enabled = false;
            tbEasy4.Enabled = false;
            tbMedium4.Enabled = false;
            tbHard4.Enabled = false;

            nudEasyHoursTask5.Enabled = false;
            nudMediumHoursTask5.Enabled = false;
            nudHardHoursTask5.Enabled = false;
            tbEasy5.Enabled = false;
            tbMedium5.Enabled = false;
            tbHard5.Enabled = false;

            nudEasyHoursTask6.Enabled = false;
            nudMediumHoursTask6.Enabled = false;
            nudHardHoursTask6.Enabled = false;
            tbEasy6.Enabled = false;
            tbMedium6.Enabled = false;
            tbHard6.Enabled = false;

            //creat test data for all stations
            PopulateStationTestData(Station1Rows);
            PopulateStationTestData(Station2Rows);
            PopulateStationTestData(Station3Rows);
            PopulateStationTestData(Station4Rows);
            PopulateStationTestData(Station5Rows);
            PopulateStationTestData(Station6Rows);
        }

        /// <summary>
        /// Fill Station1Rows with deterministic test data so EditStation and other UI can display sample entries.
        /// </summary>
        /// <summary>
        /// Fill the provided MotionRow array with deterministic test data so EditStation and other UI can display sample entries.
        /// Can be reused for Station1Rows, Station2Rows, etc.
        /// </summary>
        private void PopulateStationTestData(MotionRow[] rows)
        {
            if (rows == null) return;

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new MotionRow
                {
                    Motion = new Motion
                    {
                        textAdvance = $"Advance {i + 1}",
                        textAdvanced = $"Advanced {i + 1}",
                        textReturn = $"Return {i + 1}",
                        textReturned = $"Returned {i + 1}",
                        MotionName = $"Motion Name {i + 1}"
                    },
                    Units = (i % 3) switch
                    {
                        0 => "mm",
                        1 => "deg",
                        _ => "LU"
                    },
                    AdvanceOrder = i + 1,
                    ReturnOrder = i + 1
                };
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void label9_Click(object sender, EventArgs e) { }

        // -------------------------
        // Station1 handlers
        // -------------------------
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal.Text = tbEasy1.Value.ToString();
            KeepTotalAt100(tbEasy1, tbMedium1, tbHard1, lblEasyVal, lblMediumVal, lblHardVal);
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void tbMedium_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal.Text = tbMedium1.Value.ToString();
            KeepTotalAt100(tbMedium1, tbEasy1, tbHard1, lblMediumVal, lblEasyVal, lblHardVal);
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void tbHard_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal.Text = tbHard1.Value.ToString();
            KeepTotalAt100(tbHard1, tbEasy1, tbMedium1, lblHardVal, lblEasyVal, lblMediumVal);
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            // easy task hours changed for station1
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            // medium task hours changed for station1
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            // hard task hours changed for station1
            UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1, nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);
        }

        // New handler for the "standard" checkbox for station 1
        private void cboxStandard1_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxStandard1 == null) return;

            if (cboxStandard1.Checked)
            {
                // Set the standard values, but clamp to each NumericUpDown's min/max to avoid exceptions
                SetNumericUpDownValueSafe(nudEasyHoursTask1, 1.0m);
                SetNumericUpDownValueSafe(nudMediumHoursTask1, 3.0m);
                SetNumericUpDownValueSafe(nudHardHoursTask1, 8.0m);

                SetTrackBarValueSafe(tbEasy1, 75);
                SetTrackBarValueSafe(tbMedium1, 15);
                SetTrackBarValueSafe(tbHard1, 10);


                // Recompute station1 hours after changing the per-task hours
                UpdateHoursForStation(nudNumberOfMotions1, tbEasy1, tbMedium1, tbHard1,
                    nudEasyHoursTask1, nudMediumHoursTask1, nudHardHoursTask1, txbHoursS1);

                KeepTotalAt100(tbEasy1, tbMedium1, tbHard1, lblEasyVal, lblMediumVal, lblHardVal);

            }

            else
            {
                // Re-enable the NumericUpDowns and TrackBars for manual editing
                nudEasyHoursTask1.Enabled = true;
                nudMediumHoursTask1.Enabled = true;
                nudHardHoursTask1.Enabled = true;
                tbEasy1.Enabled = true;
                tbMedium1.Enabled = true;
                tbHard1.Enabled = true;
            }
        }

        // -------------------------
        // Station2 handlers
        // -------------------------
        private void tbEasy2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal2.Text = tbEasy2.Value.ToString();
            KeepTotalAt100(tbEasy2, tbMedium2, tbHard2, lblEasyVal2, lblMediumVal2, lblHardVal2);
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void tbMedium2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal2.Text = tbMedium2.Value.ToString();
            KeepTotalAt100(tbMedium2, tbEasy2, tbHard2, lblMediumVal2, lblEasyVal2, lblHardVal2);
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void tbHard2_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal2.Text = tbHard2.Value.ToString();
            KeepTotalAt100(tbHard2, tbEasy2, tbMedium2, lblHardVal2, lblEasyVal2, lblMediumVal2);
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void numericUpDownMotions2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void numericUpDown4_2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void numericUpDown5_2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        private void numericUpDown6_2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);
        }

        // -------------------------
        // Station3 handlers
        // -------------------------
        private void tbEasy3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal3.Text = tbEasy3.Value.ToString();
            KeepTotalAt100(tbEasy3, tbMedium3, tbHard3, lblEasyVal3, lblMediumVal3, lblHardVal3);
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void tbMedium3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal3.Text = tbMedium3.Value.ToString();
            KeepTotalAt100(tbMedium3, tbEasy3, tbHard3, lblMediumVal3, lblEasyVal3, lblHardVal3);
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void tbHard3_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal3.Text = tbHard3.Value.ToString();
            KeepTotalAt100(tbHard3, tbEasy3, tbMedium3, lblHardVal3, lblEasyVal3, lblMediumVal3);
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void numericUpDownMotions3_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void numericUpDown4_3_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void numericUpDown5_3_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        private void numericUpDown6_3_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);
        }

        // -------------------------
        // Station4 handlers
        // -------------------------
        private void tbEasy4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal4.Text = tbEasy4.Value.ToString();
            KeepTotalAt100(tbEasy4, tbMedium4, tbHard4, lblEasyVal4, lblMediumVal4, lblHardVal4);
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void tbMedium4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal4.Text = tbMedium4.Value.ToString();
            KeepTotalAt100(tbMedium4, tbEasy4, tbHard4, lblMediumVal4, lblEasyVal4, lblHardVal4);
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void tbHard4_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal4.Text = tbHard4.Value.ToString();
            KeepTotalAt100(tbHard4, tbEasy4, tbMedium4, lblHardVal4, lblEasyVal4, lblMediumVal4);
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void numericUpDownMotions4_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void numericUpDown4_4_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void numericUpDown5_4_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        private void numericUpDown6_4_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);
        }

        // -------------------------
        // Station5 handlers
        // -------------------------
        private void tbEasy5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal5.Text = tbEasy5.Value.ToString();
            KeepTotalAt100(tbEasy5, tbMedium5, tbHard5, lblEasyVal5, lblMediumVal5, lblHardVal5);
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void tbMedium5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal5.Text = tbMedium5.Value.ToString();
            KeepTotalAt100(tbMedium5, tbEasy5, tbHard5, lblMediumVal5, lblEasyVal5, lblHardVal5);
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void tbHard5_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal5.Text = tbHard5.Value.ToString();
            KeepTotalAt100(tbHard5, tbEasy5, tbMedium5, lblHardVal5, lblEasyVal5, lblMediumVal5);
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void numericUpDownMotions5_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void numericUpDown4_5_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void numericUpDown5_5_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        private void numericUpDown6_5_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);
        }

        // -------------------------
        // Station6 handlers
        // -------------------------
        private void tbEasy6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblEasyVal6.Text = tbEasy6.Value.ToString();
            KeepTotalAt100(tbEasy6, tbMedium6, tbHard6, lblEasyVal6, lblMediumVal6, lblHardVal6);
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void tbMedium6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblMediumVal6.Text = tbMedium6.Value.ToString();
            KeepTotalAt100(tbMedium6, tbEasy6, tbHard6, lblMediumVal6, lblEasyVal6, lblHardVal6);
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void tbHard6_Scroll(object sender, EventArgs e)
        {
            if (_isUpdating) return;
            lblHardVal6.Text = tbHard6.Value.ToString();
            KeepTotalAt100(tbHard6, tbEasy6, tbMedium6, lblHardVal6, lblEasyVal6, lblMediumVal6);
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void numericUpDownMotions6_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void numericUpDown4_6_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void numericUpDown5_6_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        private void numericUpDown6_6_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
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

        /// <summary>
        /// Compute total hours for a station and write into the provided textbox.
        /// totalHours = motions * ( (easyPct/100)*easyHours + (medPct/100)*medHours + (hardPct/100)*hardHours )
        /// Also updates the overall total across all stations (txbTotalHours).
        /// </summary>
        private void UpdateHoursForStation(NumericUpDown nudMotions,
            TrackBar tbEasyLocal, TrackBar tbMedLocal, TrackBar tbHardLocal,
            NumericUpDown nudEasyHours, NumericUpDown nudMedHours, NumericUpDown nudHardHours,
            TextBox txbOut)
        {
            if (nudMotions == null || tbEasyLocal == null || tbMedLocal == null || tbHardLocal == null ||
                nudEasyHours == null || nudMedHours == null || nudHardHours == null || txbOut == null)
            {
                return;
            }

            try
            {
                decimal motions = nudMotions.Value;
                decimal easyPct = tbEasyLocal.Value;
                decimal medPct = tbMedLocal.Value;
                decimal hardPct = tbHardLocal.Value;

                decimal easyHours = nudEasyHours.Value;
                decimal medHours = nudMedHours.Value;
                decimal hardHours = nudHardHours.Value;

                decimal perMotion = (easyPct * easyHours + medPct * medHours + hardPct * hardHours) / 100m;
                decimal total = motions * perMotion;

                txbOut.Text = decimal.Round(total, 2).ToString("0.##");
            }
            catch
            {
                txbOut.Text = "0";
            }
            finally
            {
                // Keep the overall total in sync whenever any station updates
                UpdateTotalHours();
            }
        }

        // Helper to safely set a NumericUpDown's Value while respecting its Minimum/Maximum
        private void SetNumericUpDownValueSafe(NumericUpDown nud, decimal desired)
        {
            if (nud == null) return;
            decimal v = desired;
            if (v < nud.Minimum) v = nud.Minimum;
            if (v > nud.Maximum) v = nud.Maximum;
            nud.Value = v;
            nud.Enabled = false;
        }

        private void SetTrackBarValueSafe(TrackBar nud, decimal desired)
        {
            if (nud == null) return;
            decimal v = desired;
            if (v < nud.Minimum) v = nud.Minimum;
            if (v > nud.Maximum) v = nud.Maximum;
            nud.Value = (int)v;
            nud.Enabled = false;

        }

        private void tpStation1_Click(object sender, EventArgs e) { }

        private void nudNumberOfMotions2_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions2, tbEasy2, tbMedium2, tbHard2, nudEasyHoursTask2, nudMediumHoursTask2, nudHardHoursTask2, txbHoursS2);

        }

        private void nudNumberOfMotions3_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions3, tbEasy3, tbMedium3, tbHard3, nudEasyHoursTask3, nudMediumHoursTask3, nudHardHoursTask3, txbHoursS3);

        }

        private void nudNumberOfMotions4_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions4, tbEasy4, tbMedium4, tbHard4, nudEasyHoursTask4, nudMediumHoursTask4, nudHardHoursTask4, txbHoursS4);

        }

        private void nudNumberOfMotions5_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions5, tbEasy5, tbMedium5, tbHard5, nudEasyHoursTask5, nudMediumHoursTask5, nudHardHoursTask5, txbHoursS5);

        }

        private void nudNumberOfMotions6_ValueChanged(object sender, EventArgs e)
        {
            UpdateHoursForStation(nudNumberOfMotions6, tbEasy6, tbMedium6, tbHard6, nudEasyHoursTask6, nudMediumHoursTask6, nudHardHoursTask6, txbHoursS6);
        }

        /// <summary>
        /// Parse a text value to decimal safely. Returns 0 when parsing fails.
        /// Uses current culture for parsing (fallback to InvariantCulture handled by TryParse overloads).
        /// </summary>
        private decimal ParseDecimalSafe(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0m;
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out var v)) return v;
            if (decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out v)) return v;
            return 0m;
        }

        /// <summary>
        /// Sum the floating-point values in txbHoursS1..txbHoursS6 and write result into txbTotalHours.
        /// Invalid or non-parsable values are treated as 0.
        /// </summary>
        private void UpdateTotalHours()
        {
            try
            {
                decimal sum = 0m;

                // Treat any unparsable text as zero
                sum += ParseDecimalSafe(txbHoursS1.Text);
                sum += ParseDecimalSafe(txbHoursS2.Text);
                sum += ParseDecimalSafe(txbHoursS3.Text);
                sum += ParseDecimalSafe(txbHoursS4.Text);
                sum += ParseDecimalSafe(txbHoursS5.Text);
                sum += ParseDecimalSafe(txbHoursS6.Text);

                if (txbTotalHours != null)
                {
                    txbTotalHours.Text = decimal.Round(sum, 2).ToString("0.##");
                }
            }
            catch
            {
                if (txbTotalHours != null)
                    txbTotalHours.Text = "0";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station1Rows);
            dlg.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station2Rows);
            dlg.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station3Rows);
            dlg.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station4Rows);
            dlg.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station5Rows);
            dlg.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var dlg = new EditStation(Station6Rows);
            dlg.Show(this);
        }

        private void weekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditWeek frm = new frmEditWeek();
            frm.ShowDialog();
        }
    }
}
