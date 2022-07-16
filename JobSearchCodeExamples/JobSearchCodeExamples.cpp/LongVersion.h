#pragma once
#using <System.dll>

using namespace System;
using namespace System::Globalization;

public ref class LongVersion : IComparable
{
private:
	array<int>^ _parts;
public:
	LongVersion(String^ version);

	property array<int>^ Parts {
public: array<int>^ get() { return _parts; }
private: void set(array<int>^ value) { _parts = value; }
	}

	virtual bool Equals(Object^ obj) override;
	virtual int GetHashCode() override;
	virtual String^ ToString() override;

	// Inherited via IComparable
	virtual int CompareTo(System::Object^ obj);

	// Static operator overloads
	static bool operator == (LongVersion^ left, LongVersion^ right);
	static bool operator != (LongVersion^ left, LongVersion^ right);
	static bool operator <  (LongVersion^ left, LongVersion^ right);
	static bool operator <= (LongVersion^ left, LongVersion^ right);
	static bool operator >  (LongVersion^ left, LongVersion^ right);
	static bool operator >= (LongVersion^ left, LongVersion^ right);
};

