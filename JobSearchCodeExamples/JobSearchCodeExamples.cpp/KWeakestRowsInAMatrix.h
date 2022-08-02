#pragma once
#using <System.dll>

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Linq;

public ref class KWeakestRowsInAMatrix
{
public:
	static array<int>^ KWeakestRows(array<array<int>^>^ mat, int k);
private:
	static int Compare(KeyValuePair<int, int> i1, KeyValuePair<int, int> i2);
};

