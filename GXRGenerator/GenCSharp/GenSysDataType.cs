// GenDataType.h: interface for the GenDataType.
//
//////////////////////////////////////////////////////////////////////


using System.Runtime.InteropServices;

public enum Focus
	{
		enumFocusSmall     = 0, ///< small focus
	    enumFocusLarge     = 1  ///< large focus
	}

public enum Tube
	{
		enumTubeTube1     = 0, ///< Tube1
	    enumTubeTube2     = 1  ///< Tube2
	}

public enum Technique
	{
		enumTechniquemAms  = 0, ///< mA/ms
		enumTechniqueMAS   = 1, ///< mAs
		enumTechniqueAEC   = 2, ///< AEC
		enumTechniquemAsms = 3  ///< mAs/ms
	}

public enum AECField
	{
		enumAECFieldRight  = 1, ///< ÓÒ
		enumAECFieldCenter = 2, ///< ÖÐ
		enumAECFieldCR     = 3, ///< ÖÐÓÒ
		enumAECFieldLeft   = 4, ///< ×ó
		enumAECFieldLR     = 5, ///< ×óÓÒ
		enumAECFieldLC     = 6, ///< ×óÖÐ
		enumAECFieldLCR    = 7  ///< ×óÖÐÓÒ
	}

public enum AECFilm
	{
		enumAECFilmLow     = 0, ///< Low Speed
	    enumAECFilmMedium  = 1, ///< Middle Speed
		enumAECFilmHigh    = 2  ///< High Speed
	}

public enum AuxiliaryType
	{
		enumAuxiliaryFreeCassette  = 0, ///< FreeCassette
	    enumAuxiliaryTableBucky    = 1, ///< TableBucky
		enumAuxiliaryWallBucky     = 2, ///< WallBucky
		enumAuxiliarySpotFilm      = 3, ///< SpotFilm
		enumAuxiliaryDigital       = 4, ///< Digital
		enumAuxiliaryTomo          = 5  ///< Tomo
	}

public enum GeneratorPhase
	{
		enumGenPhaseInitialization = 1, ///< Initialization Phase
		enumGenPhaseStandby        = 2, ///< Standby Phase
		enumGenPhaseRADPrep        = 3, ///< RAD Prep Phase
		enumGenPhaseRADReady       = 4, ///< RAD Ready Phase
		enumGenPhaseRADExposure    = 5, ///< RAD exposure Phase		
		enumGenPhaseRADHangover    = 6, ///< RAD Hangover Phase
		
		enumGenPhaseFLUOPrep       = 7, ///< FLUO Prep Phase
		enumGenPhaseFLUOExposure   = 8, ///< FLUO Exposure Phase
		enumGenPhaseFLUOHangover   = 9, ///< FLUO Hangover Phase

		enumGenPhaseError          = 10, ///< Error Phase
		enumGenPhaseNotValid       = 11  ///< Other Phases
	
	}


public enum FunCallResult
	{
		enumSuccess                 = 0, ///< Call funtion success
		enumFailure                 = 1, ///< Call funtion failed
		enumParamInvalid            = 2  ///< Function's input parameter is invalid
	}

public struct APRSourceData
	{
    public int nKV;                    ///< kV, range is [40, 150]
    public float fMA;                  ///< mA, range make reference to mA table
    public float fMS;                  ///< ms, range make reference to ms table
    public float fMAS;                 ///< mAs, range make reference to mAs table
    public AuxiliaryType enumAuxiliary; ///< Auxiliary
    public Focus enumFocus;            ///< Focus
    public Technique enumTechnique;    ///< Technique
    public AECField enumAECField;      ///< AEC Field
    public AECFilm enumAECFilm;        ///< AECFilm
    public int nAECDensity;            ///< AECDensity, range is [-8, 8]
	}

public struct AuxEnableInfo
	{
    public AuxiliaryType enumAuxType;
    public bool bEnabled;      
	}

public struct GenAuxEnableInfo
{
    [MarshalAs(UnmanagedType.LPArray, SizeConst = 5)]
    public AuxEnableInfo[] structAuxEnableList; 
      
	}

public struct GenDoseRate
{

    [MarshalAs(UnmanagedType.LPArray, SizeConst = 12)]
    public int[] nDoseValue;
}

public enum CommunicationMode
	{
		enumCAN                      = 0, ///<  CAN communication
		enumSerial                   = 1, ///<  Serial communication
		
	}

