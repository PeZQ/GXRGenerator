// Gen.h

#pragma once

using namespace System;

namespace Gen {

	public ref class Gen
	{
	public:
		bool Init(IntPtr^ handle) {
			HWND hwnd =(HWND)handle->ToPointer();
			bool ret = GIInitGenerator(hwnd);
			return ret;
		}
		// TODO:  �ڴ˴���Ӵ���ķ�����
	};
}
