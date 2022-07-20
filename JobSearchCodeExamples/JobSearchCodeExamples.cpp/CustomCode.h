#pragma once
#using <System.dll>

using namespace System;
using namespace System::Globalization;
using namespace System::Linq;

public ref class CustomCode
{
public:
	static int VersionCompare(String^ version1, String^ version2);
	static int LongVersionCompare(String^ version1, String^ version2);
	static int FindMissingEntry(array<int>^ values);
	static bool LongVersionEqual(String^ version1, String^ version2);
	static bool LongVersionLess(String^ version1, String^ version2);
	static bool LongVersionLessEqual(String^ version1, String^ version2);
	static bool LongVersionGreater(String^ version1, String^ version2);
	static bool LongVersionGreaterEqual(String^ version1, String^ version2);
};
