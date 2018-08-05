// IGenSysInterface.h: Interface declaration  for the IGenSysInterface.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_IGENSYSINTERFACE_H__10E316FE_895F_4DB2_B743_42436B7121A8__INCLUDED_)
#define AFX_IGENSYSINTERFACE_H__10E316FE_895F_4DB2_B743_42436B7121A8__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

///< Interface Function Declaration
///< 1) *******************************************************************
///< Name: GIIncreaseKVOneStep() 
///< Function Description: Increase kV according to step length, and step length is one
///< 
///< Parameter: [out] int & nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseKVOneStep(int & nKV);

///< 2) *******************************************************************
///< Name: GIDecreaseKVOneStep() 
///< Function Description: Decrease kV according to step length, and step length is one
///< 
///< Parameter: [out] int & nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseKVOneStep(int & nKV);

///< 3) *******************************************************************
///< Name: GIIncreaseKVFiveSteps() 
///< Function Description: Increase kV according to step length, and step length is five
///< 
///< Parameter: [out] int & nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseKVFiveSteps(int & nKV);

///< 4) *******************************************************************
///< Name: GIDecreaseKVFiveSteps() 
///< Function Description: Decrease kV according to step length, and step length is five
///< 
///< Parameter: [out] int & nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseKVFiveSteps(int & nKV);

///< 5) *******************************************************************
///< Name: GIGetKV() 
///< Function Description: Get kV value from the generator
///< 
///< Parameter: [out] int & nKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetKV(int & nKV);

///< 6) *******************************************************************
///< Name: GISetKV() 
///< Function Description: Set kV value to the generator
///< 
///< Parameter: [in] const int nInputKV ///< kV value(Range: 40---150), Unit: kV
///< Parameter: [out] int & nOutputKV ///< Only when success, Output generator current kV's value (Range: 40---150), Unit: kV
///< 
///< return [FunCallResult]: Success(enumSuccess)
///<                         Failure(enumFailure)
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
extern "C"  FunCallResult _stdcall GISetKV(const int nInputKV, int & nOutputKV);

///< 7) *******************************************************************
///< Name: GIIncreaseMAOneStep() 
///< Function Description: Increase mA value one step to the generator,
///<                       step length depend on mA tables 
///< Parameter: [out] float & fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMAOneStep(float & fMA);

///< 8) *******************************************************************
///< Name: GIDecreaseMAOneStep() 
///< Function Description: Decrease mA value one step to the generator, 
///<                       step length depend on mA tables
///< Parameter: [out] float & fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMAOneStep(float & fMA);

///< 9) *******************************************************************
///< Name: GIIncreaseMAFiveSteps() 
///< Function Description: Increase mA value  five steps to the generator, 
///<                       step length depend on mA tables
///< Parameter: [out] float & fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMAFiveSteps(float & fMA);

///< 10) ******************************************************************
///< Name: GIDecreaseMAFiveSteps() 
///< Function Description: Decrease mA value  five steps to the generator, 
///<                       step length depend on mA tables
///< Parameter: [out] float & fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMAFiveSteps(float & fMA);

///< 11) ******************************************************************
///< Name: GIGetMA() 
///< Function Description: Get mA value from the generator
///< 
///< Parameter: [out] float & fMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetMA(float & fMA);

///< 12) ******************************************************************
///< Name: GISetMA() 
///< Function Description: Set mA value to the generator
///<                       
///< Parameter: [in] const float fInputMA ///< mA value, range make reference to mA table
///< Parameter: [out] float & fOutputMA ///< Only when success, Output generator current mA's value, Unit: mA
///< 
///< return [FunCallResult]: Success(enumSuccess)
///<                         Failure(enumFailure)
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
extern "C"  FunCallResult _stdcall GISetMA(const float fInputMA, float & fOutputMA);

///< 13) ******************************************************************
///< Name: GIIncreaseMSOneStep() 
///< Function Description: Increase ms value  one step to the generator, 
///<                       step length depend on ms tables.
///< Parameter: [out] float & fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMSOneStep(float & fMS);

///< 14) ******************************************************************
///< Name: GIDecreaseMSOneStep() 
///< Function Description: Decrease ms value  one step to the generator,
///<                       step length depend on ms tables. 
///< Parameter: [out] float & fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMSOneStep(float & fMS);

///< 15) ******************************************************************
///< Name: GIIncreaseMSFiveSteps() 
///< Function Description: Increase ms value  five steps to the generator,
///<                       step length depend on ms tables. 
///< Parameter: [out] float & fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMSFiveSteps(float & fMS);

///< 16) ******************************************************************
///< Name: GIDecreaseMSFiveSteps() 
///< Function Description: Decrease ms value  five steps to the generator,
///<                       step length depend on ms tables. 
///< Parameter: [out] float & fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMSFiveSteps(float & fMS);

///< 17) ******************************************************************
///< Name: GIGetMS() 
///< Function Description: Get ms value from the generator
///< 
///< Parameter: [out] float & fMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetMS(float & fMS);

///< 18) ******************************************************************
///< Name: GISetMS() 
///< Function Description: Set ms value to the generator
///<  
///< Parameter: [in] const float fInputMS ///< ms value, range make reference to ms table
///< Parameter: [out] float & fOutputMS ///< Only when success, Output generator current ms's value, Unit: ms
///< 
///< return [FunCallResult]: Success(enumSuccess)
///<                         Failure(enumFailure)
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
extern "C"  FunCallResult _stdcall GISetMS(const float fInputMS, float & fOutputMS);

///< 19) ******************************************************************
///< Name: GIIncreaseMASOneStep() 
///< Function Description: Increase mAs value  one step to the generator,
///<                       step length depend on mAs tables.  
///< Parameter: [out] float & fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMASOneStep(float & fMAS);

///< 20) ******************************************************************
///< Name: GIDecreaseMASOneStep() 
///< Function Description: Decrease mAs value  one step to the generator,
///<                       step length depend on mAs tables.  
///< Parameter: [out] float & fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMASOneStep(float & fMAS);

///< 21) ******************************************************************
///< Name: GIIncreaseMASFiveSteps() 
///< Function Description: Increase mAs value  five steps to the generator,
///<                       step length depend on mAs tables.  
///< Parameter: [out] float & fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIIncreaseMASFiveSteps(float & fMAS);

///< 22) ******************************************************************
///< Name: GIDecreaseMASFiveSteps() 
///< Function Description: Decrease mAs value  five steps to the generator,
///<                       step length depend on mAs tables.
///< Parameter: [out] float & fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIDecreaseMASFiveSteps(float & fMAS);

///< 23) ******************************************************************
///< Name: GIGetMAS() 
///< Function Description: Get mAs value from the generator
///< 
///< Parameter: [out] float & fMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetMAS(float & fMAS);

///< 24) ******************************************************************
///< Name: GISetMAS() 
///< Function Description: Set mAs value to the generator
///< 
///< Parameter: [in] const float fInputMAS ///< mAs value, range make reference to mAs table
///< Parameter: [out] float & fOutputMAS ///< Only when success, Output generator current mAs's value, Unit: mAs
///< 
///< return [FunCallResult]: Success(enumSuccess)
///<                         Failure(enumFailure)
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
extern "C"  FunCallResult _stdcall GISetMAS(const float fInputMAS, float & fOutputMAS);

///< 25) ******************************************************************
///< Name: GIGetPostMAS() 
///< Function Description: Get post mAs of the last exposure
///< 
///< Parameter: None
///< 
///< return [float]: Post mAs of the last exposure (0 ~ AEC backup mAs), Unit: mAs
///< 
///<***********************************************************************
extern "C"  float _stdcall GIGetPostMAS();

///< 26) ******************************************************************
///< Name: GIGetPostMS() 
///< Function Description: Get post ms of the last exposure 
///< 
///< Parameter: None
///< 
///< return [float]: Post ms of the last exposure (0 ~ AEC backup ms), Unit: ms
///< 
///<***********************************************************************
extern "C"  float _stdcall GIGetPostMS();

///< 27) ******************************************************************
///< Name: GIGetFocus() 
///< Function Description: Get current exposure focus from the generator 
///< 
///< Parameter: [out] Focus & enumFocus ///< Only when success, output focus
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetFocus(Focus & enumFocus);

///< 28) ******************************************************************
///< Name: GISetFocus() 
///< Function Description: Set current exposure focus to the generator 
///< 
///< Parameter: [in] const Focus enumInputFocus ///< Exposure focus, range make reference to "Focus" type define
///< Parameter: [out] Focus & enumOutputFocus   ///< Only when success, output focus
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GISetFocus(const Focus enumInputFocus, Focus & enumOutputFocus);

///< 29) ******************************************************************
///< Name: GIGetTechnique() 
///< Function Description: Get exposure technique from the generator
///< 
///< Parameter: [out] Technique & enumTechnique ///< Only when success, output technique
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetTechnique(Technique & enumTechnique);

///< 30) ******************************************************************
///< Name: GISetTechnique() 
///< Function Description: Set exposure technique to the generator
///< 
///< Parameter: [in] const Technique enumInputTechnique///< exposure technique, range make reference to "Technique" type define
///< Parameter: [out] Technique & enumOutputTechnique ///< Only when success, output technique
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GISetTechnique(const Technique enumInputTechnique, Technique & enumOutputTechnique);

///< 31) ******************************************************************
///< Name: GIGetAECExpectedExposureTime() 
///< Function Description: Get AEC expected exposure time in ms
///< 
///< Parameter: [out] int & nAECExpectedExpTime ///< Only when success, output exposure time of AEC expected
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetAECExpectedExposureTime(int & nAECExpectedExpTime);

///< 32) ******************************************************************
///< Name: GIGetAECDensity() 
///< Function Description: Get AEC exposure density from the generator
///< 
///< Parameter: [out] int & nAECDensity ///< Only when success, Output AEC Density(Range: -8 --- 8)
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetAECDensity(int & nAECDensity);

///< 33) ******************************************************************
///< Name: GISetAECDensity() 
///< Function Description: Set AEC exposure density to the generator
///< 
///< Parameter: [in] const int nInputAECDensity///< AEC exposure density(Range: -8 --- 8)
///< Parameter: [out] int & nOutputAECDensity ///< Only when success, Output AEC Density(Range: -8 --- 8)
///< 
///< return [FunCallResult]: Success(enumSuccess)
///<                         Failure(enumFailure)
///<                         Input parameter is invalid (enumParamInvalid)
///< 
///<***********************************************************************
extern "C"  FunCallResult _stdcall GISetAECDensity(const int nInputAECDensity, int & nOutputAECDensity);

///< 34) ******************************************************************
///< Name: GIGetAECField() 
///< Function Description: Get AEC field from the generator
///< 
///< Parameter: [out] AECField & enumAECField ///< Only when success, Output AECField
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetAECField(AECField & enumAECField);

///< 35) ******************************************************************
///< Name: GISetAECField() 
///< Function Description: Set AEC field to the generator
///< 
///< Parameter: [in] const AECField enumInputAECField///< AEC field, range make reference to "AECField" type define
///< Parameter: [out] AECField & enumOutputAECField ///< Only when success, Output AECField
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GISetAECField(const AECField enumInputAECField, AECField & enumOutputAECField);

///< 36) ******************************************************************
///< Name: GIGetAECFilm() 
///< Function Description: Get AEC film screen speed type from the generator
///< 
///< Parameter: [out] AECFilm & enumAECFilm ///< Only when success, Output AECFilm
///< 
///< return [BOOL]: Success(TRUE) 
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetAECFilm(AECFilm & enumAECFilm);

///< 37) ******************************************************************
///< Name: GISetAECFilm() 
///< Function Description: Set AEC film screen speed type to the generator
///< 
///< Parameter: [in] const AECFilm enumInputAECFilm ///< AEC film screen speed type, range make reference to "AECFilm" type define 
///< Parameter: [out] AECFilm & enumOutputAECFilm ///< Only when success, Output AECFilm
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GISetAECFilm(const AECFilm enumInputAECFilm, AECFilm & enumOutputAECFilm);

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
FunCallResult _stdcall GIApplyAPRData(APRSourceData scAPRSourceData);

///< 39) ******************************************************************
///< Name: GIInitGenerator() 
///< Function Description: Initialize generator
///< 
///< Parameter: [in] HWND hwnd///< Handle of window is used to accept message
///< 
///< return [BOOL]: Success(TRUE), Initialize generator success
///<                Failure(FALSE), Initialize generator failed
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIInitGenerator(HWND hwnd);

///< 40) ******************************************************************
///< Name: GIGetGenPhase() 
///< Function Description: Get current generator phase
///< 
///< Parameter: [out] GeneratorPhase & enumCurGenPhase ///< Only when success, Output current generator phase 
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetGenPhase(GeneratorPhase & enumCurGenPhase);

///< 41) ******************************************************************
///< Name: GICloseGenCommunication() 
///< Function Description: Close the communication with generator
///< 
///< Parameter: None
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GICloseGenCommunication();

///< 42) ******************************************************************
///< Name: GIGetTubeHeatPercent() 
///< Function Description: Get percent value of the anode heat from generator
///< 
///< Parameter: [out] int & nTubeHeatPercent ///< Only when success, Output percent value of tube heat
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetTubeHeatPercent(int & nTubeHeatPercent);

///< 43) ******************************************************************
///< Name: GICheckGenCommIsNormal()
///< Function Description: Check whether the communciation with  the generator is OK
///< 
///< Parameter: None
///< 
///< return [BOOL]: Communciation is OK(TRUE)
///<                Communciation is interrupted(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GICheckGenCommIsNormal();

///< 44) ******************************************************************
///< Name: GIGetCurrentWorkingTube() 
///< Function Description: Get the working tube currently used
///< 
///< Parameter: [out] Tube & enumCurWorkingTube ///< Only when success, Output current working tube
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetCurrentWorkingTube(Tube & enumCurWorkingTube);

///< 45) ******************************************************************
///< Name: GIGetGenMaxKW() 
///< Function Description: Get the max kW value of the generator
///< 
///< Parameter: [out] int & nGenMaxKW ///< Only when success, Output the generator's max KW
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetGenMaxKW(int & nGenMaxKW);

///< 46) ******************************************************************
///< Name: GIResetGenError() 
///< Function Description: Reset the generator after an error repoted
///< 
///< Parameter: None
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIResetGenError();

///< 47) ******************************************************************
///< Name: GIGetTubeHeatLimits() 
///< Function Description: Get the two limit values for tube heat indication
///< 
///< Parameter: [out] int & nWarningValue ///< Only when success, output warning value
///< Parameter: [out] int & nLimitValue ///< Only when success, output limit value
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetTubeHeatLimits(int & nWarningValue, int & nLimitValue);

///< 48) ******************************************************************
///< Name: GIGetAuxiliary() 
///< Function Description: Get current auxiliary from the generator
///< 
///< Parameter: [out] AuxiliaryType & enumAuxiliary ///< Only when success, output Auxiliary
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GIGetAuxiliary(AuxiliaryType & enumAuxiliary);

///< 49) ******************************************************************
///< Name: GISetAuxiliary() 
///< Function Description: Set current auxiliary to the generator
///< 
///< Parameter: [in] const AuxiliaryType enumInputAuxiliary ///< Auxiliary, range make reference to "AuxiliaryType" type define
///< Parameter: [out] AuxiliaryType & enumOutputAuxiliary ///< Only when success, output Auxiliary
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C"  BOOL _stdcall GISetAuxiliary(const AuxiliaryType enumInputAuxiliary, AuxiliaryType & enumOutputAuxiliary);

///< 50) ******************************************************************
///< Name: GIGetHVCommDLLVersion() 
///< Function Description: Get version information of "HVComm" dll
///< 
///< Parameter: None
///< 
///< return [char * ]: Version information of "HVComm" dll
///< 
///<***********************************************************************
extern "C"  char * _stdcall GIGetHVCommDLLVersion();

///< 51) ******************************************************************
///< Name: GIGetDoseRateValues() 
///< Function Description: Get dose rate data from generator
///< 
///< Parameter: None
///< 
///< return [int* ]: dose rate data (12)
///< 
///<***********************************************************************
extern "C" BOOL  _stdcall GIGetDoseRateValues(GenDoseRate& dose);

///< 52) ******************************************************************
///< Name: GIGetDAPValueAfterExposure 
///< Function Description: Get DAP value of an exposure
///< 
///< Parameter: [in] double dArea : 射线在床面板投影面积,单位是m2
///<            [in] double dHeight : 床面板到球管中心的实际高度,单位是cm
///<            [out] double& dDAPValue: 当次曝光的DAP值
///<
///< return [BOOL]: Succeed (TRUE)   Fail(FALSE)
///< 
///<***********************************************************************
extern "C" BOOL  _stdcall GIGetDAPValueAfterExposure(double dArea, double dHeight, double& dDAPValue);

///< 53) ******************************************************************
///< Name: GIGetGenCurAPRData() 
///< Function Description: Get current APR data from the generator
///< 
///< Parameter: [out] APRSourceData & scOutputCurAPRSourceData ///< Only when success, output current APR data from the generator
///< 
///< return [BOOL]: Success(TRUE)
///<                Failure(FALSE)
///< 
///<***********************************************************************
extern "C" BOOL _stdcall GIGetGenCurAPRData(APRSourceData & scOutputCurAPRSourceData);

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
extern char * _stdcall GIGetGenErrorInformation(int nErrorMsglparam, int &nErrorLevel);

///< 55) ******************************************************************
///< Name: GIGetAuxiliaryEnabledInformation
///< Function Description: Get AuxiliaryType array of enabled auxiliary 
///<                        
///<
///< Parameter: [out] GenAuxEnableInfo& structGenAuxEnable: all the enabled 
///<             and disabled information of auxiliaries of the generator
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed
///<
///<***********************************************************************

extern "C" BOOL _stdcall GIGetAuxiliaryEnabledInformation(GenAuxEnableInfo& structGenAuxEnable);

///< 56) ******************************************************************
///< Name: GIGetAuxiliaryAECEnabledInformation
///< Function Description: Check if the auxiliary is AEC enabled 
///<                        
///<
///< Parameter: [in] AuxiliaryType aux: auxiliary
///<            [out] BOOL& bAECEnabled: TRUE- AEC enabled  FALSE- AEC disabled
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed
///<
///<***********************************************************************

extern "C" BOOL _stdcall GIGetAuxiliaryAECEnabledInformation(AuxiliaryType aux, BOOL& bAECEnabled);

///< 57) ******************************************************************
///< Name: GIGetAECFieldConfig
///< Function Description: Get the field config value of the auxiliary 
///<                        
///<
///< Parameter: [in] AuxiliaryType aux: auxiliary
///<            [out] int& nConfig: 
///<                  1-Right Field Only
///<                  2-Center Field Only
///<                  3-Right and Center field enabled
///<                  4-Left Field Only 
///<                  5-Left and Right field enabled
///<                  6-Center and Left field enabled
///<　　　　　　　　　7-Left,Center and Right field enabled 
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed
///<
///<***********************************************************************

extern "C" BOOL _stdcall GIGetAECFieldConfig(AuxiliaryType aux, int& nConfig);
///< 58) ******************************************************************
///< Name: GIGetAECFilmSpeedConfig
///< Function Description: Get the Film Speed config value of the auxiliary 
///<                        
///<
///< Parameter: [in] AuxiliaryType aux: auxiliary
///<            [out] int& nConfig: 
///<                  1-Low speed only 
///<                  2-Medium speed only
///<                  3-Low and Medium speed enabled
///<                  4-High speed only 
///<                  5-Low and High speed enabled 
///<                  6-Medium and High speed enabled　　　 
///<                  7-Low, Medium and High speed enabled 
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed
///<
///<***********************************************************************

extern "C" BOOL _stdcall GIGetAECFilmSpeedConfig(AuxiliaryType aux, int& nConfig);
///< 59) ******************************************************************
///< Name: GICheckAllowOperation
///< Function Description: Check if generator allows exposure parameter setting 
///<                        
///<
///< Parameter: none 
///< 
///< return [BOOL]: TRUE - allow  FALSE - forbid
///<
///<***********************************************************************
extern "C" BOOL _stdcall GICheckGenAllowOperation();
///< 60) ******************************************************************
///< Name: GISetCommunicationMode
///< Function Description: Set communication mode between computer running
///<                        generator library and generator
///<                        
///<
///< Parameter: [in]  mode : communication mode
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed 
///<
///<***********************************************************************
extern "C" BOOL _stdcall GISetCommunicationMode(CommunicationMode mode);

///< 61) ******************************************************************
///< Name: GISetSerialCommPort
///< Function Description: Set port number for serial communication
///<                        
///<
///< Parameter: [in]  nPortNumber : port number
///< 
///< return [BOOL]: TRUE - succeeded  FALSE - failed 
///<
///<***********************************************************************
extern "C" BOOL _stdcall GISetSerialCommPort(int nPortNumber);



#endif // !defined(AFX_IGENSYSINTERFACE_H__10E316FE_895F_4DB2_B743_42436B7121A8__INCLUDED_)
