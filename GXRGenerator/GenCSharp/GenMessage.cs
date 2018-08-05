// GenMessage.h: interface for the GenMessage class.
//
//////////////////////////////////////////////////////////////////////
public class GenMessage
{

    public static int WM_GEN_MESSAGE = 0x0400 + 1000;  ///<Message from generator

    public static int GEN_WPM_RAD_EXP = 1;   ///<Generaor is in RAD exposure phase
    public static int GEN_WPM_RAD_PR = 2;   ///<Generaor is in RAD preperation phase
    public static int GEN_WPM_FLUO_PR = 3;   ///<Generaor is in FLUO preperation phase
    public static int GEN_WPM_FLUO_EXP = 4; ///<Generaor is in FLUO exposure phase
    public static int GEN_WPM_ERR1 = 5;  ///<Generator is reporting error
    public static int GEN_WPM_ERR2 = 6;  ///<Generator is reporting error


    public static int GEN_LPM_START = 2;  ///<exposure or preperation phase of RAD or FLUO has started      
    public static int GEN_LPM_END = 1;  ///<RAD or FLUO expoure phase: exposure finished;
                                        ///<RAD or FLUO preperation phase: tube stops rotating (preperation phase terminated; RAD or FLUO finished). 
    public static int GEN_LPM_RAD_READY = 3;  ///<RAD preperation phase:preperation has finished and ready to take RAD exposure

    public static int ErrorLevel_NotValid = 0;
    public static int ErrorLevel_Notice = 4;
    public static int ErrorLevel_Warning = 5;
    public static int ErrorLevel_Reset = 6;
    public static int ErrorLevel_Fatal = 7;

}