// GenVC.cpp: ����Ŀ�ļ���

#include "stdafx.h"
#include "Gen.h"
#include "TestForm.h"

using namespace System;
using namespace  System::Windows::Forms;

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	Console::WriteLine(L"Hello World");
	// �ڴ����κοؼ�֮ǰ���� Windows XP ���ӻ�Ч��
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false); 

	// ���������ڲ�������
	Application::Run(gcnew Gen::TestForm());
	Console::ReadLine();
	return 0;
}
