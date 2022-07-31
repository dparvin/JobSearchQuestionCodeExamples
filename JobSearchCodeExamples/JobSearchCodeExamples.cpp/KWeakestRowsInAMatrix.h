#pragma once
#using <System.dll>

using namespace System;

public ref class KWeakestRowsInAMatrix
{
public:
	static array<int>^ KWeakestRows(array<array<int>^>^ mat, int k);
};

