// IGenSysInterface.h: Interface declaration  for the IGenSysInterface.
//
//////////////////////////////////////////////////////////////////////
using System.Runtime.InteropServices;
public class IGenSysInterface {
    ///< Interface Function Declaration
    ///< 1) *******************************************************************
    ///< Name: GIIncreaseKVOneStep() 
    ///< Function Description: Increase kV according to step length, and step length is one
    ///< 
    ///< Parameter: [out] ref int nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseKVOneStep(ref int nKV);

    ///< 2) *******************************************************************
    ///< Name: GIDecreaseKVOneStep() 
    ///< Function Description: Decrease kV according to step length, and step length is one
    ///< 
    ///< Parameter: [out] ref int nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseKVOneStep(ref int nKV);

    ///< 3) *******************************************************************
    ///< Name: GIIncreaseKVFiveSteps() 
    ///< Function Description: Increase kV according to step length, and step length is five
    ///< 
    ///< Parameter: [out] ref int nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseKVFiveSteps(ref int nKV);

    ///< 4) *******************************************************************
    ///< Name: GIDecreaseKVFiveSteps() 
    ///< Function Description: Decrease kV according to step length, and step length is five
    ///< 
    ///< Parameter: [out] ref int nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseKVFiveSteps(ref int nKV);

    ///< 5) *******************************************************************
    ///< Name: GIGetKV() 
    ///< Function Description: Get kV value from the generator
    ///< 
    ///< Parameter: [out] ref int nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetKV(ref int nKV);

    ///< 6) *******************************************************************
    ///< Name: GISetKV() 
    ///< Function Description: Set kV value to the generator
    ///< 
    ///< Parameter: [in] int nInputKV ///< kV value(Range: 40---150), Unit: kV
    ///< Parameter: [out] ref int nOutputKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
    ///< 
    ///< return [FunCallResult]: Success(enumSuccess)
    ///<                         Failure(enumFailure)
    ///<                         Input parameter is invalid (enumParamInvalid)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static FunCallResult GISetKV(int nInputKV, ref int nOutputKV);

///< 7) *******************************************************************
///< Name: GIIncreaseMAOneStep() 
///< Function Description: Increase mA value one step to the generator,
///<                       step length depend on mA tables 
///< Parameter: [out] ref float fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMAOneStep(ref float fMA);

    ///< 8) *******************************************************************
    ///< Name: GIDecreaseMAOneStep() 
    ///< Function Description: Decrease mA value one step to the generator, 
    ///<                       step length depend on mA tables
    ///< Parameter: [out] ref float fMA ///< Only when success, Output generator current mA's value, Unit: mA
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMAOneStep(ref float fMA);

    ///< 9) *******************************************************************
    ///< Name: GIIncreaseMAFiveSteps() 
    ///< Function Description: Increase mA value  five steps to the generator, 
    ///<                       step length depend on mA tables
    ///< Parameter: [out] ref float fMA ///< Only when success, Output generator current mA's value, Unit: mA
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMAFiveSteps(ref float fMA);

    ///< 10) ******************************************************************
    ///< Name: GIDecreaseMAFiveSteps() 
    ///< Function Description: Decrease mA value  five steps to the generator, 
    ///<                       step length depend on mA tables
    ///< Parameter: [out] ref float fMA ///< Only when success, Output generator current mA's value, Unit: mA
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMAFiveSteps(ref float fMA);

    ///< 11) ******************************************************************
    ///< Name: GIGetMA() 
    ///< Function Description: Get mA value from the generator
    ///< 
    ///< Parameter: [out] ref float fMA ///< Only when success, Output generator current mA's value, Unit: mA
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetMA(ref float fMA);

    ///< 12) ******************************************************************
    ///< Name: GISetMA() 
    ///< Function Description: Set mA value to the generator
    ///<                       
    ///< Parameter: [in] float fInputMA ///< mA value, range make reference to mA table
    ///< Parameter: [out] ref float fOutputMA ///< Only when success, Output generator current mA's value, Unit: mA
    ///< 
    ///< return [FunCallResult]: Success(enumSuccess)
    ///<                         Failure(enumFailure)
    ///<                         Input parameter is invalid (enumParamInvalid)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static  FunCallResult  GISetMA(float fInputMA, ref float fOutputMA);

///< 13) ******************************************************************
///< Name: GIIncreaseMSOneStep() 
///< Function Description: Increase ms value  one step to the generator, 
///<                       step length depend on ms tables.
///< Parameter: [out] ref float fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMSOneStep(ref float fMS);

    ///< 14) ******************************************************************
    ///< Name: GIDecreaseMSOneStep() 
    ///< Function Description: Decrease ms value  one step to the generator,
    ///<                       step length depend on ms tables. 
    ///< Parameter: [out] ref float fMS ///< Only when success, Output generator current ms's value, Unit: ms
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMSOneStep(ref float fMS);

    ///< 15) ******************************************************************
    ///< Name: GIIncreaseMSFiveSteps() 
    ///< Function Description: Increase ms value  five steps to the generator,
    ///<                       step length depend on ms tables. 
    ///< Parameter: [out] ref float fMS ///< Only when success, Output generator current ms's value, Unit: ms
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMSFiveSteps(ref float fMS);

    ///< 16) ******************************************************************
    ///< Name: GIDecreaseMSFiveSteps() 
    ///< Function Description: Decrease ms value  five steps to the generator,
    ///<                       step length depend on ms tables. 
    ///< Parameter: [out] ref float fMS ///< Only when success, Output generator current ms's value, Unit: ms
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMSFiveSteps(ref float fMS);

    ///< 17) ******************************************************************
    ///< Name: GIGetMS() 
    ///< Function Description: Get ms value from the generator
    ///< 
    ///< Parameter: [out] ref float fMS ///< Only when success, Output generator current ms's value, Unit: ms
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetMS(ref float fMS);

    ///< 18) ******************************************************************
    ///< Name: GISetMS() 
    ///< Function Description: Set ms value to the generator
    ///<  
    ///< Parameter: [in] float fInputMS ///< ms value, range make reference to ms table
    ///< Parameter: [out] ref float fOutputMS ///< Only when success, Output generator current ms's value, Unit: ms
    ///< 
    ///< return [FunCallResult]: Success(enumSuccess)
    ///<                         Failure(enumFailure)
    ///<                         Input parameter is invalid (enumParamInvalid)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static  FunCallResult  GISetMS(float fInputMS, ref float fOutputMS);

///< 19) ******************************************************************
///< Name: GIIncreaseMASOneStep() 
///< Function Description: Increase mAs value  one step to the generator,
///<                       step length depend on mAs tables.  
///< Parameter: [out] ref float fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMASOneStep(ref float fMAS);

    ///< 20) ******************************************************************
    ///< Name: GIDecreaseMASOneStep() 
    ///< Function Description: Decrease mAs value  one step to the generator,
    ///<                       step length depend on mAs tables.  
    ///< Parameter: [out] ref float fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMASOneStep(ref float fMAS);

    ///< 21) ******************************************************************
    ///< Name: GIIncreaseMASFiveSteps() 
    ///< Function Description: Increase mAs value  five steps to the generator,
    ///<                       step length depend on mAs tables.  
    ///< Parameter: [out] ref float fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIIncreaseMASFiveSteps(ref float fMAS);

    ///< 22) ******************************************************************
    ///< Name: GIDecreaseMASFiveSteps() 
    ///< Function Description: Decrease mAs value  five steps to the generator,
    ///<                       step length depend on mAs tables.
    ///< Parameter: [out] ref float fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIDecreaseMASFiveSteps(ref float fMAS);

    ///< 23) ******************************************************************
    ///< Name: GIGetMAS() 
    ///< Function Description: Get mAs value from the generator
    ///< 
    ///< Parameter: [out] ref float fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetMAS(ref float fMAS);

    ///< 24) ******************************************************************
    ///< Name: GISetMAS() 
    ///< Function Description: Set mAs value to the generator
    ///< 
    ///< Parameter: [in] float fInputMAS ///< mAs value, range make reference to mAs table
    ///< Parameter: [out] ref float fOutputMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
    ///< 
    ///< return [FunCallResult]: Success(enumSuccess)
    ///<                         Failure(enumFailure)
    ///<                         Input parameter is invalid (enumParamInvalid)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static  FunCallResult  GISetMAS(float fInputMAS, ref float fOutputMAS);

///< 25) ******************************************************************
///< Name: GIGetPostMAS() 
///< Function Description: Get post mAs of the last exposure
///< 
///< Parameter: None
///< 
///< return [float]: Post mAs of the last exposure (0 ~ AEC backup mAs), Unit: mAs
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static  float  GIGetPostMAS();

    ///< 26) ******************************************************************
    ///< Name: GIGetPostMS() 
    ///< Function Description: Get post ms of the last exposure 
    ///< 
    ///< Parameter: None
    ///< 
    ///< return [float]: Post ms of the last exposure (0 ~ AEC backup ms), Unit: ms
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static  float  GIGetPostMS();

    ///< 27) ******************************************************************
    ///< Name: GIGetFocus() 
    ///< Function Description: Get current exposure focus from the generator 
    ///< 
    ///< Parameter: [out] ref Focus enumFocus ///< Only when success, output focus
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetFocus(ref Focus enumFocus);

    ///< 28) ******************************************************************
    ///< Name: GISetFocus() 
    ///< Function Description: Set current exposure focus to the generator 
    ///< 
    ///< Parameter: [in] Focus enumInputFocus ///< Exposure focus, range make reference to "Focus" type define
    ///< Parameter: [out] ref Focus enumOutputFocus   ///< Only when success, output focus
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GISetFocus(Focus enumInputFocus, ref Focus enumOutputFocus);

///< 29) ******************************************************************
///< Name: GIGetTechnique() 
///< Function Description: Get exposure technique from the generator
///< 
///< Parameter: [out] ref Technique enumTechnique ///< Only when success, output technique
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIGetTechnique(ref Technique enumTechnique);

    ///< 30) ******************************************************************
    ///< Name: GISetTechnique() 
    ///< Function Description: Set exposure technique to the generator
    ///< 
    ///< Parameter: [in] Technique enumInputTechnique///< exposure technique, range make reference to "Technique" type define
    ///< Parameter: [out] ref Technique enumOutputTechnique ///< Only when success, output technique
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GISetTechnique(Technique enumInputTechnique, ref Technique enumOutputTechnique);

///< 31) ******************************************************************
///< Name: GIGetAECExpectedExposureTime() 
///< Function Description: Get AEC expected exposure time in ms
///< 
///< Parameter: [out] ref int nAECExpectedExpTime ///< Only when success, output exposure time of AEC expected
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIGetAECExpectedExposureTime(ref int nAECExpectedExpTime);

    ///< 32) ******************************************************************
    ///< Name: GIGetAECDensity() 
    ///< Function Description: Get AEC exposure density from the generator
    ///< 
    ///< Parameter: [out] ref int nAECDensity ///< Only when success, Output AEC Density(Range: -8 --- 8)
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetAECDensity(ref int nAECDensity);

    ///< 33) ******************************************************************
    ///< Name: GISetAECDensity() 
    ///< Function Description: Set AEC exposure density to the generator
    ///< 
    ///< Parameter: [in] int nInputAECDensity///< AEC exposure density(Range: -8 --- 8)
    ///< Parameter: [out] ref int nOutputAECDensity ///< Only when success, Output AEC Density(Range: -8 --- 8)
    ///< 
    ///< return [FunCallResult]: Success(enumSuccess)
    ///<                         Failure(enumFailure)
    ///<                         Input parameter is invalid (enumParamInvalid)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static  FunCallResult  GISetAECDensity(int nInputAECDensity, ref int nOutputAECDensity);

///< 34) ******************************************************************
///< Name: GIGetAECField() 
///< Function Description: Get AEC field from the generator
///< 
///< Parameter: [out] ref AECField enumAECField ///< Only when success, Output AECField
///< 
///< return [bool]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIGetAECField(ref AECField enumAECField);

    ///< 35) ******************************************************************
    ///< Name: GISetAECField() 
    ///< Function Description: Set AEC field to the generator
    ///< 
    ///< Parameter: [in] AECField enumInputAECField///< AEC field, range make reference to "AECField" type define
    ///< Parameter: [out] ref AECField enumOutputAECField ///< Only when success, Output AECField
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GISetAECField(AECField enumInputAECField, ref AECField enumOutputAECField);

///< 36) ******************************************************************
///< Name: GIGetAECFilm() 
///< Function Description: Get AEC film screen speed type from the generator
///< 
///< Parameter: [out] ref AECFilm enumAECFilm ///< Only when success, Output AECFilm
///< 
///< return [bool]: Success(TRUE) 
///<                Failure(FALSE)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static bool GIGetAECFilm(ref AECFilm enumAECFilm);

    ///< 37) ******************************************************************
    ///< Name: GISetAECFilm() 
    ///< Function Description: Set AEC film screen speed type to the generator
    ///< 
    ///< Parameter: [in] AECFilm enumInputAECFilm ///< AEC film screen speed type, range make reference to "AECFilm" type define 
    ///< Parameter: [out] ref AECFilm enumOutputAECFilm ///< Only when success, Output AECFilm
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GISetAECFilm(AECFilm enumInputAECFilm, ref AECFilm enumOutputAECFilm);

///< 38) ******************************************************************
///< Name: GIApplyAPRData() 
///< Function Description: Apply the APR data to the generator
///< 
///< Parameter: [in] APRSourceData scAPRSourceData///< APR source data struct 
///< 
///< return [FunCallResult]: Success(enumSuccess), Apply the APR data to the generator success
///<                         Failure(enumFailure), Apply the APR data to the generator failed
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static FunCallResult  GIApplyAPRData(APRSourceData scAPRSourceData);

    ///< 39) ******************************************************************
    ///< Name: GIInitGenerator() 
    ///< Function Description: Initialize generator
    ///< 
    ///< Parameter: [in] HWND hwnd///< Handle of window is used to accept message
    ///< 
    ///< return [bool]: Success(TRUE), Initialize generator success
    ///<                Failure(FALSE), Initialize generator failed
    ///< 
    ///<***********************************************************************
    [DllImport(@"HVcomm.dll")]
    public extern static bool GIInitGenerator(System.IntPtr hwnd);

    ///< 40) ******************************************************************
    ///< Name: GIGetGenPhase() 
    ///< Function Description: Get current generator phase
    ///< 
    ///< Parameter: [out] ref GeneratorPhase enumCurGenPhase ///< Only when success, Output current generator phase 
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport(@"HVcomm.dll")]
    public extern static bool GIGetGenPhase(ref GeneratorPhase enumCurGenPhase);

    ///< 41) ******************************************************************
    ///< Name: GICloseGenCommunication() 
    ///< Function Description: Close the communication with generator
    ///< 
    ///< Parameter: None
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GICloseGenCommunication();

    ///< 42) ******************************************************************
    ///< Name: GIGetTubeHeatPercent() 
    ///< Function Description: Get percent value of the anode heat from generator
    ///< 
    ///< Parameter: [out] ref int nTubeHeatPercent ///< Only when success, Output percent value of tube heat
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetTubeHeatPercent(ref int nTubeHeatPercent);

    ///< 43) ******************************************************************
    ///< Name: GICheckGenCommIsNormal()
    ///< Function Description: Check whether the communciation with  the generator is OK
    ///< 
    ///< Parameter: None
    ///< 
    ///< return [bool]: Communciation is OK(TRUE)
    ///<                Communciation is interrupted(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GICheckGenCommIsNormal();

    ///< 44) ******************************************************************
    ///< Name: GIGetCurrentWorkingTube() 
    ///< Function Description: Get the working tube currently used
    ///< 
    ///< Parameter: [out] ref Tube enumCurWorkingTube ///< Only when success, Output current working tube
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetCurrentWorkingTube(ref Tube enumCurWorkingTube);

    ///< 45) ******************************************************************
    ///< Name: GIGetGenMaxKW() 
    ///< Function Description: Get the max kW value of the generator
    ///< 
    ///< Parameter: [out] ref int nGenMaxKW ///< Only when success, Output the generator's max KW
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetGenMaxKW(ref int nGenMaxKW);

    ///< 46) ******************************************************************
    ///< Name: GIResetGenError() 
    ///< Function Description: Reset the generator after an error repoted
    ///< 
    ///< Parameter: None
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIResetGenError();

    ///< 47) ******************************************************************
    ///< Name: GIGetTubeHeatLimits() 
    ///< Function Description: Get the two limit values for tube heat indication
    ///< 
    ///< Parameter: [out] ref int nWarningValue ///< Only when success, output warning value
    ///< Parameter: [out] ref int nLimitValue ///< Only when success, output limit value
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetTubeHeatLimits(ref int nWarningValue, ref int nLimitValue);

    ///< 48) ******************************************************************
    ///< Name: GIGetAuxiliary() 
    ///< Function Description: Get current auxiliary from the generator
    ///< 
    ///< Parameter: [out] ref AuxiliaryType enumAuxiliary ///< Only when success, output Auxiliary
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GIGetAuxiliary(ref AuxiliaryType enumAuxiliary);

    ///< 49) ******************************************************************
    ///< Name: GISetAuxiliary() 
    ///< Function Description: Set current auxiliary to the generator
    ///< 
    ///< Parameter: [in] AuxiliaryType enumInputAuxiliary ///< Auxiliary, range make reference to "AuxiliaryType" type define
    ///< Parameter: [out] ref AuxiliaryType enumOutputAuxiliary ///< Only when success, output Auxiliary
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool GISetAuxiliary(AuxiliaryType enumInputAuxiliary, ref AuxiliaryType enumOutputAuxiliary);

///< 50) ******************************************************************
///< Name: GIGetHVCommDLLVersion() 
///< Function Description: Get version information of "HVComm" dll
///< 
///< Parameter: None
///< 
///< return [char * ]: Version information of "HVComm" dll
///< 
///<***********************************************************************
[DllImport("HVcomm.dll")]
    public extern static  string  GIGetHVCommDLLVersion();

    ///< 51) ******************************************************************
    ///< Name: GIGetDoseRateValues() 
    ///< Function Description: Get dose rate data from generator
    ///< 
    ///< Parameter: None
    ///< 
    ///< return [int* ]: dose rate data (12)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetDoseRateValues(ref GenDoseRate dose);

    ///< 52) ******************************************************************
    ///< Name: GIGetDAPValueAfterExposure 
    ///< Function Description: Get DAP value of an exposure
    ///< 
    ///< Parameter: [in] double dArea : 射线在床面板投影面积,单位是m2
    ///<            [in] double dHeight : 床面板到球管中心的实际高度,单位是cm
    ///<            [out] ref double dDAPValue: 当次曝光的DAP值
    ///<
    ///< return [bool]: Succeed (TRUE)   Fail(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetDAPValueAfterExposure(double dArea, double dHeight, ref double dDAPValue);

    ///< 53) ******************************************************************
    ///< Name: GIGetGenCurAPRData() 
    ///< Function Description: Get current APR data from the generator
    ///< 
    ///< Parameter: [out] ref APRSourceData scOutputCurAPRSourceData ///< Only when success, output current APR data from the generator
    ///< 
    ///< return [bool]: Success(TRUE)
    ///<                Failure(FALSE)
    ///< 
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetGenCurAPRData(ref APRSourceData scOutputCurAPRSourceData);

    ///< 54) ******************************************************************
    ///< Name: GIGetGenErrorInformation() 
    ///< Function Description: Get an error information when receiving it from 
    ///<                       the generator 
    ///<
    ///< Parameter: [in] nErrorMsglparam : lparam of the message received
    ///<            [out] nErrorLevel : error level for display 
    ///<                           0 - nErrorMsglparam not valid or failed to 
    ///<                               get error information
    ///<                           4 - Notice 
    ///<                           5 - Warning
    ///<                           6 - Error
    ///<                           7 - Fatal Error
    ///< 
    ///< return [char*]: error message
    ///<
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public static extern string  GIGetGenErrorInformation(int nErrorMsglparam, ref int nErrorLevel);

    ///< 55) ******************************************************************
    ///< Name: GIGetAuxiliaryEnabledInformation
    ///< Function Description: Get AuxiliaryType array of enabled auxiliary 
    ///<                        
    ///<
    ///< Parameter: [out] ref GenAuxEnableInfo structGenAuxEnable: all the enabled 
    ///<             and disabled information of auxiliaries of the generator
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed
    ///<
    ///<***********************************************************************

    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetAuxiliaryEnabledInformation(ref GenAuxEnableInfo structGenAuxEnable);

    ///< 56) ******************************************************************
    ///< Name: GIGetAuxiliaryAECEnabledInformation
    ///< Function Description: Check if the auxiliary is AEC enabled 
    ///<                        
    ///<
    ///< Parameter: [in] AuxiliaryType aux: auxiliary
    ///<            [out] ref bool bAECEnabled: TRUE- AEC enabled  FALSE- AEC disabled
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed
    ///<
    ///<***********************************************************************

    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetAuxiliaryAECEnabledInformation(AuxiliaryType aux, ref bool bAECEnabled);

    ///< 57) ******************************************************************
    ///< Name: GIGetAECFieldConfig
    ///< Function Description: Get the field config value of the auxiliary 
    ///<                        
    ///<
    ///< Parameter: [in] AuxiliaryType aux: auxiliary
    ///<            [out] ref int nConfig: 
    ///<                  1-Right Field Only
    ///<                  2-Center Field Only
    ///<                  3-Right and Center field enabled
    ///<                  4-Left Field Only 
    ///<                  5-Left and Right field enabled
    ///<                  6-Center and Left field enabled
    ///<　　　　　　　　　7-Left,Center and Right field enabled 
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed
    ///<
    ///<***********************************************************************

    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetAECFieldConfig(AuxiliaryType aux, ref int nConfig);
    ///< 58) ******************************************************************
    ///< Name: GIGetAECFilmSpeedConfig
    ///< Function Description: Get the Film Speed config value of the auxiliary 
    ///<                        
    ///<
    ///< Parameter: [in] AuxiliaryType aux: auxiliary
    ///<            [out] ref int nConfig: 
    ///<                  1-Low speed only 
    ///<                  2-Medium speed only
    ///<                  3-Low and Medium speed enabled
    ///<                  4-High speed only 
    ///<                  5-Low and High speed enabled 
    ///<                  6-Medium and High speed enabled　　　 
    ///<                  7-Low, Medium and High speed enabled 
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed
    ///<
    ///<***********************************************************************

    [DllImport("HVcomm.dll")]
    public extern static bool  GIGetAECFilmSpeedConfig(AuxiliaryType aux, ref int nConfig);
    ///< 59) ******************************************************************
    ///< Name: GICheckAllowOperation
    ///< Function Description: Check if generator allows exposure parameter setting 
    ///<                        
    ///<
    ///< Parameter: none 
    ///< 
    ///< return [bool]: TRUE - allow  FALSE - forbid
    ///<
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GICheckGenAllowOperation();
    ///< 60) ******************************************************************
    ///< Name: GISetCommunicationMode
    ///< Function Description: Set communication mode between computer running
    ///<                        generator library and generator
    ///<                        
    ///<
    ///< Parameter: [in]  mode : communication mode
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed 
    ///<
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GISetCommunicationMode(CommunicationMode mode);

    ///< 61) ******************************************************************
    ///< Name: GISetSerialCommPort
    ///< Function Description: Set port number for serial communication
    ///<                        
    ///<
    ///< Parameter: [in]  nPortNumber : port number
    ///< 
    ///< return [bool]: TRUE - succeeded  FALSE - failed 
    ///<
    ///<***********************************************************************
    [DllImport("HVcomm.dll")]
    public extern static bool  GISetSerialCommPort(int nPortNumber);

}
