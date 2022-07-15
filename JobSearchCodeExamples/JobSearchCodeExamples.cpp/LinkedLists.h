#pragma once
#using <System.dll>

using namespace System;
using namespace System::Collections::Generic;

public ref class LinkedLists
{
public:
	generic<typename T>
	static LinkedList<T>^ ReverseList(LinkedList<T>^ list);
};
