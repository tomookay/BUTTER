using System;
using System.Windows.Forms;

namespace BUTTER
{
    public partial class EditStation : Form
    {
        private MotionRow[] _rows = Array.Empty<MotionRow>();
        private const int VisibleRows = 6;

        // control arrays (top-to-bottom order)
        private Button[] _btnAdvance;
        private Button[] _btnReturn;
        private TextBox[] _tbAdvance;
        private TextBox[] _tbAdvanced;
        private TextBox[] _tbMotionName;
        private TextBox[] _tbReturn;
        private TextBox[] _tbReturned;

        public EditStation()
        {
            InitializeComponent();
            // keep default ctor usable if designer uses it
        }

        // New ctor: pass the station rows you want to browse/edit
        public EditStation(MotionRow[] rows) : this()
        {
            _rows = rows ?? Array.Empty<MotionRow>();
            InitializeControlArrays();
            ConfigureScrollBar();
            PopulateAtIndex(0);
            vScrollBar1.Scroll += VScrollBar1_Scroll;
            vScrollBar1.ValueChanged += VScrollBar1_Scroll;
        }

        private void InitializeControlArrays()
        {
            // Controls ordered from top row (index 0) to bottom (index 5)
            _btnAdvance = new Button[] { btnOrderAdvance1, btnOrderAdvance2, btnOrderAdvance3, btnOrderAdvance4, btnOrderAdvance5, btnOrderAdvance6 };
            _btnReturn = new Button[] { btnOrderReturn1, btnOrderReturn2, btnOrderReturn3, btnOrderReturn4, btnOrderReturn5, btnOrderReturn6 };

            _tbAdvance = new TextBox[] { txbAdvance1, txbAdvance2, txbAdvance3, txbAdvance4, txbAdvance5, txbAdvance6 };
            _tbAdvanced = new TextBox[] { txbAdvanced1, txbAdvanced2, txbAdvanced3, txbAdvanced4, txbAdvanced5, txbAdvanced6 };
            _tbMotionName = new TextBox[] { txbMotionName1, txbMotionName2, txbMotionName3, txbMotionName4, txbMotionName5, txbMotionName6 };
            _tbReturn = new TextBox[] { txbReturn1, txbReturn2, txbReturn3, txbReturn4, txbReturn5, txbReturn6 };
            _tbReturned = new TextBox[] { txbReturned1, txbReturned2, txbReturned3, txbReturned4, txbReturned5, txbReturned6 };
        }

        private void ConfigureScrollBar()
        {
            // configure scrollbar so Value can act as the start index for visible rows
            int maxStart = Math.Max(0, _rows.Length - VisibleRows);
            vScrollBar1.Minimum = 0;
            // VScrollBar.Maximum behaves oddly with LargeChange, keep it safe:
            vScrollBar1.Maximum = maxStart;
            vScrollBar1.LargeChange = 1;
            vScrollBar1.SmallChange = 1;
            vScrollBar1.Enabled = (_rows.Length > 0);
            vScrollBar1.Value = 0;
        }

        private void VScrollBar1_Scroll(object sender, EventArgs e)
        {
            PopulateAtIndex(vScrollBar1.Value);
        }

        // Populate the visible controls starting at 'startIndex'
        private void PopulateAtIndex(int startIndex)
        {
            for (int rowSlot = 0; rowSlot < VisibleRows; rowSlot++)
            {
                int sourceIndex = startIndex + rowSlot;
                bool hasSource = sourceIndex >= 0 && sourceIndex < _rows.Length && _rows[sourceIndex] != null;

                // enable/disable the whole set for this slot
                _btnAdvance[rowSlot].Enabled = hasSource;
                _btnReturn[rowSlot].Enabled = hasSource;
                _tbAdvance[rowSlot].Enabled = hasSource;
                _tbAdvanced[rowSlot].Enabled = hasSource;
                _tbMotionName[rowSlot].Enabled = hasSource;
                _tbReturn[rowSlot].Enabled = hasSource;
                _tbReturned[rowSlot].Enabled = hasSource;

                if (hasSource)
                {
                    var r = _rows[sourceIndex];
                    // Defensive null checks for Motion
                    var m = r.Motion ?? new Motion();
                    _tbAdvance[rowSlot].Text = m.textAdvance ?? "";
                    _tbAdvanced[rowSlot].Text = m.textAdvanced ?? "";
                    _tbMotionName[rowSlot].Text = m.MotionName ?? "";
                    _tbReturn[rowSlot].Text = m.textReturn ?? "";
                    _tbReturned[rowSlot].Text = m.textReturned ?? "";

                    // store source index into Tag so button handlers can know which MotionRow they refer to
                    _btnAdvance[rowSlot].Tag = sourceIndex;
                    _btnReturn[rowSlot].Tag = sourceIndex;
                }
                else
                {
                    _tbAdvance[rowSlot].Text = "";
                    _tbAdvanced[rowSlot].Text = "";
                    _tbMotionName[rowSlot].Text = "";
                    _tbReturn[rowSlot].Text = "";
                    _tbReturned[rowSlot].Text = "";
                    _btnAdvance[rowSlot].Tag = null;
                    _btnReturn[rowSlot].Tag = null;
                }
            }
        }

        // Example: if you want to push changes back into the array, call this before closing
        private void CommitVisibleEditsToModel()
        {
            int startIndex = vScrollBar1.Value;
            for (int rowSlot = 0; rowSlot < VisibleRows; rowSlot++)
            {
                int sourceIndex = startIndex + rowSlot;
                if (sourceIndex < 0 || sourceIndex >= _rows.Length) continue;

                var row = _rows[sourceIndex] ??= new MotionRow();
                row.Motion ??= new Motion();

                row.Motion.textAdvance = _tbAdvance[rowSlot].Text;
                row.Motion.textAdvanced = _tbAdvanced[rowSlot].Text;
                row.Motion.MotionName = _tbMotionName[rowSlot].Text;
                row.Motion.textReturn = _tbReturn[rowSlot].Text;
                row.Motion.textReturned = _tbReturned[rowSlot].Text;
            }
        }

        // Optionally call CommitVisibleEditsToModel in the FormClosing event if you want changes saved
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CommitVisibleEditsToModel();
            base.OnFormClosing(e);
        }

        private void EditStation_Load(object sender, EventArgs e)
        {

        }
    }
}
