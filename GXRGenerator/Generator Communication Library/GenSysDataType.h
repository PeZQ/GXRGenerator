// GenDataType.h: interface for the GenDataType.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_GENDATATYPE_H__2C5B689C_6C52_4845_891E_6E79BD317600__INCLUDED_)
#define AFX_GENDATATYPE_H__2C5B689C_6C52_4845_891E_6E79BD317600__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#define  ErrorLevel_NotValid  0
#define  ErrorLevel_Notice    4
#define  ErrorLevel_Warning   5
#define  ErrorLevel_Reset     6
#define  ErrorLevel_Fatal     7


    typedef enum _Focus
	{
		enumFocus_Small     = 0, ///< small focus
	    enumFocus_Large     = 1  ///< large focus
	}Focus;

    typedef enum _Tube
	{
		enumTube_Tube1     = 0, ///< Tube1
	    enumTube_Tube2     = 1  ///< Tube2
	}Tube;
	 
    typedef enum _Technique
	{
		enumTechnique_mAms  = 0, ///< mA/ms
		enumTechnique_MAS   = 1, ///< mAs
		enumTechnique_AEC   = 2, ///< AEC
		enumTechnique_mAsms = 3  ///< mAs/ms
	}Technique;
	
	typedef enum _AECField
	{
		enumAECField_Right  = 1, ///< ÓÒ
		enumAECField_Center = 2, ///< ÖÐ
		enumAECField_CR     = 3, ///< ÖÐÓÒ
		enumAECField_Left   = 4, ///< ×ó
		enumAECField_LR     = 5, ///< ×óÓÒ
		enumAECField_LC     = 6, ///< ×óÖÐ
		enumAECField_LCR    = 7  ///< ×óÖÐÓÒ
	}AECField;

	typedef enum _AECFilm
	{
		enumAECFilm_Low     = 0, ///< Low Speed
	    enumAECFilm_Medium  = 1, ///< Middle Speed
		enumAECFilm_High    = 2  ///< High Speed
	}AECFilm;

	typedef enum _AuxiliaryType
	{
		enumAuxiliary_FreeCassette  = 0, ///< FreeCassette
	    enumAuxiliary_TableBucky    = 1, ///< TableBucky
		enumAuxiliary_WallBucky     = 2, ///< WallBucky
		enumAuxiliary_SpotFilm      = 3, ///< SpotFilm
		enumAuxiliary_Digital       = 4, ///< Digital
		enumAuxiliary_Tomo          = 5  ///< Tomo
	}AuxiliaryType;

	typedef enum _GeneratorPhase
	{
		enumGenPhase_Initialization = 1, ///< Initialization Phase
		enumGenPhase_Standby        = 2, ///< Standby Phase
		enumGenPhase_RADPrep        = 3, ///< RAD Prep Phase
		enumGenPhase_RADReady       = 4, ///< RAD Ready Phase
		enumGenPhase_RADExposure    = 5, ///< RAD exposure Phase		
		enumGenPhase_RADHangover    = 6, ///< RAD Hangover Phase
		
		enumGenPhase_FLUOPrep       = 7, ///< FLUO Prep Phase
		enumGenPhase_FLUOExposure   = 8, ///< FLUO Exposure Phase
		enumGenPhase_FLUOHangover   = 9, ///< FLUO Hangover Phase

		enumGenPhase_Error          = 10, ///< Error Phase
		enumGenPhase_NotValid       = 11  ///< Other Phases
	
	}GeneratorPhase;


	typedef enum _FunCallResult
	{
		enumSuccess                 = 0, ///< Call funtion success
		enumFailure                 = 1, ///< Call funtion failed
		enumParamInvalid            = 2  ///< Function's input parameter is invalid
	}FunCallResult;

	typedef struct _APRSourceData
	{
		int nKV;                    ///< kV, range is [40, 150]
		float fMA;                  ///< mA, range make reference to mA table
		float fMS;                  ///< ms, range make reference to ms table
		float fMAS;                 ///< mAs, range make reference to mAs table
		AuxiliaryType enumAuxiliary; ///< Auxiliary
		Focus enumFocus;            ///< Focus
		Technique enumTechnique;    ///< Technique
        AECField enumAECField;      ///< AEC Field
        AECFilm enumAECFilm;        ///< AECFilm
		int nAECDensity;            ///< AECDensity, range is [-8, 8]
	}APRSourceData;	

	typedef struct _AuxEnableInfo
	{
		AuxiliaryType enumAuxType;  
	    BOOL          bEnabled;      
	}AuxEnableInfo;

	typedef struct _GenAuxEnableInfo
	{
		AuxEnableInfo structAuxEnableList[5]; 
      
	}GenAuxEnableInfo;

	typedef struct _GenDoseRate
	{
		int nDoseValue[12]; 
      
	}GenDoseRate;

	typedef enum _CommunicationMode
	{
		enumCAN                      = 0, ///<  CAN communication
		enumSerial                   = 1, ///<  Serial communication
		
	}CommunicationMode;


	
#endif // !defined(AFX_GENDATATYPE_H__2C5B689C_6C52_4845_891E_6E79BD317600__INCLUDED_)
