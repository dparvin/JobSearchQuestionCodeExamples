#pragma once
#using <System.dll>

using namespace System;
using namespace System::Globalization;

public ref class CustomCode
{
public:
	static int VersionCompare(String^ version1, String^ version2);
	static int LongVersionCompare(String^ version1, String^ version2);
};
