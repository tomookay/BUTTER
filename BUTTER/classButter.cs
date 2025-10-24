using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUTTER
{
    internal class classButter
    {
    }

    // Add this public container type inside the same namespace (outside the Form1 class)
    // so XmlSerializer has a concrete root object to serialize.
    public class ButterData
    {
        public List<MotionRow> Station1 { get; set; } = new();
        public List<MotionRow> Station2 { get; set; } = new();
        public List<MotionRow> Station3 { get; set; } = new();
        public List<MotionRow> Station4 { get; set; } = new();
        public List<MotionRow> Station5 { get; set; } = new();
        public List<MotionRow> Station6 { get; set; } = new();
    }
}
