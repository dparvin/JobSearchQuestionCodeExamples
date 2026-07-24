#include "ToInt.h"

/// <summary>
/// Romans to int.
/// </summary>
/// <param name="s">The string containing the roman numerals to convert to an integer.</param>
/// <returns></returns>
int ToInt::RomanToInt(String^ s)
{
	int pos = 0;
	int result = 0;
	array<System::Char>^ chars = s->ToCharArray();
	while (pos < chars->Length)
	{
		System::Char spos = chars[pos];
		System::Char snext = 0;
		if (pos < chars->Length - 1)
			snext = chars[pos + 1];
		if (spos == L'I')
		{
			if (snext == L'V')
			{
				result += 4;
				pos++;
			}
			else if (snext == L'X')
			{
				result += 9;
				pos++;
			}
			else
				result += 1;
		}
		else if (spos == L'V') result += 5;
		else if (spos == L'X')
		{
			if (snext == L'L')
			{
				result += 40;
				pos++;
			}
			else if (snext == L'C')
			{
				result += 90;
				pos++;
			}
			else
				result += 10;
		}
		else if (spos == L'L') result += 50;
		else if (spos == L'C')
		{
			if (snext == L'D')
			{
				result += 400;
				pos++;
			}
			else if (snext == L'M')
			{
				result += 900;
				pos++;
			}
			else
				result += 100;
		}
		else if (spos == L'D') result += 500;
		else if (spos == L'M') result += 1000;
		pos++;
	}
	return result;
}

int ToInt::RomanToInt2(String^ s)
{
	array<String^>^ roman = { "I", "V", "X", "L", "C", "D", "M" };
	array<int>^ values = { 1, 5, 10, 50, 100, 500, 1000 };
	array<String^>^ before = { "I", "X", "C" };
	array<array<String^>^>^ after = { { "V", "X" }, { "L", "C" }, { "D", "M" } };
	array<array<int>^>^ extraValues = { { 4, 9 }, { 40, 90 }, { 400, 900 } };
	int pos = 0;
	int result = 0;
	array<System::Char>^ chars = s->ToCharArray();
	while (pos < chars->Length)
	{
		String^ spos = chars[pos].ToString();
		String^ snext = "";
		if (pos < chars->Length - 1)
			snext = chars[pos + 1].ToString();
		int romanIndex = Array::IndexOf(roman, spos);
		int beforeIndex = Array::IndexOf(before, spos);
		if (beforeIndex >= 0 && !String::IsNullOrEmpty(snext))
		{
			int afterIndex = Array::IndexOf(after[beforeIndex], snext);
			if (afterIndex >= 0)
			{
				result += extraValues[beforeIndex][afterIndex];
				pos++;
			}
			else
				result += values[romanIndex];
		}
		else
			result += values[romanIndex];
		pos++;
	}
	return result;
}

int ToInt::RomanToInt3(String^ s)
{
	Dictionary<System::String^, int>^ RomanValues = gcnew Dictionary<System::String^, int>();
	RomanValues->Add("I", 1);
	RomanValues->Add("V", 5);
	RomanValues->Add("X", 10);
	RomanValues->Add("L", 50);
	RomanValues->Add("C", 100);
	RomanValues->Add("D", 500);
	RomanValues->Add("M", 1000);
	int pos = 0;
	int result = 0;
	array<System::Char>^ chars = s->ToCharArray();
	while (pos < chars->Length)
	{
		String^ spos = chars[pos].ToString();
		String^ snext = "";
		if (pos < chars->Length - 1)
			snext = chars[pos + 1].ToString();
		int val = 0;
		if (!RomanValues->TryGetValue(spos, val))
			throw gcnew ArgumentException("Invalid Roman numeral character: " + spos);
		int valNext = 0;
		RomanValues->TryGetValue(snext, valNext);
		if (String::IsNullOrEmpty(snext))
			result += val;
		else if (val < valNext)
			result -= val;
		else
			result += val;
		pos++;
	}
	return result;
}