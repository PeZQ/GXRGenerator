// GenMessage.h: interface for the GenMessage class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_GENMESSAGE_H__1AD1C34D_470B_4CA7_939F_3AD56FD37D51__INCLUDED_)
#define AFX_GENMESSAGE_H__1AD1C34D_470B_4CA7_939F_3AD56FD37D51__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#define		WM_GEN_MESSAGE  WM_USER+1000   ///<Message from generator

#define		GEN_WPM_RAD_EXP			1      ///<Generaor is in RAD exposure phase
#define		GEN_WPM_RAD_PR			2      ///<Generaor is in RAD preperation phase
#define		GEN_WPM_FLUO_PR		    3      ///<Generaor is in FLUO preperation phase
#define		GEN_WPM_FLUO_EXP     	4      ///<Generaor is in FLUO exposure phase
#define     GEN_WPM_ERR1            5      ///<Generator is reporting error
#define     GEN_WPM_ERR2            6      ///<Generator is reporting error


#define     GEN_LPM_START           2      ///<exposure or preperation phase of RAD or FLUO has started      
#define     GEN_LPM_END             1      ///<RAD or FLUO expoure phase: exposure finished;
                                           ///<RAD or FLUO preperation phase: tube stops rotating (preperation phase terminated; RAD or FLUO finished). 
#define     GEN_LPM_RAD_READY       3      ///<RAD preperation phase:preperation has finished and ready to take RAD exposure



#endif // !defined(AFX_GENMESSAGE_H__1AD1C34D_470B_4CA7_939F_3AD56FD37D51__INCLUDED_)
