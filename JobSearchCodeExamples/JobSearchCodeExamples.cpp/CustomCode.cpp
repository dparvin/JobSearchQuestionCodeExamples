#include "CustomCode.h"
#include "LongVersion.h"

/// <summary>
/// Versions the compare.
/// </summary>
/// <param name="version1">The version1.</param>
/// <param name="version2">The version2.</param>
/// <returns></returns>
int CustomCode::VersionCompare(String^ version1, String^ version2)
{
	array<String^>^ v1 = version1->Split('.');
	array<String^>^ v2 = version2->Split('.');
	int longest = v1->Length < v2->Length ? v2->Length : v1->Length;
	for (int i = 0; i < longest; i++)
	{
		Int32 item1 = 0;
		Int32 item2 = 0;
		if (i < v1->Length) item1 = Int32::Parse(v1[i], CultureInfo::InvariantCulture);
		if (i < v2->Length) item2 = Int32::Parse(v2[i], CultureInfo::InvariantCulture);
		int result = item1 < item2 ? -1 : item1 > item2 ? 1 : 0;
		if (result != 0) return result;
	}
	return 0;
}

/// <summary>
/// Longs the version compare.
/// </summary>
/// <param name="version1">The version1.</param>
/// <param name="version2">The version2.</param>
/// <returns></returns>
int CustomCode::LongVersionCompare(String^ version1, String^ version2)
{
	LongVersion^ v1 = gcnew LongVersion(version1);
	LongVersion^ v2 = gcnew LongVersion(version2);

	return v1->CompareTo(v2);
}

/// <summary>
/// Finds the missing entry.
/// </summary>
/// <param name="values">The values.</param>
/// <returns></returns>
int CustomCode::FindMissingEntry(array<int>^ values)
{
	return ((values->Length + 1) * (values->Length + 2) / 2) - Enumerable::Sum(values);
}
