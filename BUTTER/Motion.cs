using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUTTER
{
 
    public class Motion
    {
        public String textAdvance;
        public String textAdvanced;
        public String textReturn;
        public String textReturned;
        public String MotionName;
        //interlocks not implemented yet
    }


    public class MotionRow
    {
        public Motion Motion;
     //   public Motion AbsMotion;
        public String Units;
        public int AdvanceOrder;
        public int ReturnOrder;
              

    }



}
