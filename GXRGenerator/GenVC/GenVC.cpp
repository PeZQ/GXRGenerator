// GenVC.cpp: ����Ŀ�ļ���

#include "stdafx.h"
#include "Gen.h"

using namespace System;

int main(array<System::String ^> ^args)
{
    Console::WriteLine(L"Hello World");
	GenVC::Gen^ gen=gcnew GenVC::Gen();
    Console::ReadLine();
    return 0;
}
