#include "RansomNote.h"

bool RansomNote::CanConstruct(String^ ransomNote, String^ magazine)
{
	if (magazine->Length < ransomNote->Length) return false;
	String^ source = magazine;
	for (int i = 0; i < ransomNote->Length; i++)
		if (source->Contains(ransomNote[i]))
			source = source->Remove(source->IndexOf(ransomNote[i]), 1);
		else
			return false;
	return true;
}
