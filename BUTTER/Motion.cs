using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public float SpecialHours; //special hours to add to calculation, 0 if none
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


    public class MachineData
    {
        public int numPneumatics;
        public int numHydraulics;
        public int numLube;

        public int numIOmodules;
        public bool hasRobot;
        public bool hasSpecialDevices;

        public bool hasAutoScanIO;
        public bool hasSoftwareSafetyProgram;
        public int numSafeyZones;
        public int numEStopButtons;
        public int numSafetyDoors;
        public int numLightCurtains;



    }



}
