#pragma once
using namespace System;
using namespace System::Collections::Generic;
using namespace System::Linq;

public ref class RansomNote
{
public:
	static bool CanConstruct(String^ ransomNote, String^ magazine);
};

