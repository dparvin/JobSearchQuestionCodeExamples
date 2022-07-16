#include "EmployeeCoverage.h"

int EmployeeCoverage::MaxCoverage(array<String^>^ employees)
{
	array<int>^ combined = gcnew array<int>(employees->Length);
	for (int i = 0; i < employees->Length; i++)
	{
		array<String^>^ years = employees[i]->Split('-');
		int startDate = Int32::Parse(years[0]);
		int endDate = Int32::Parse(years[1]);
		for (int j = i + 1; j < employees->Length; j++)
		{
			array<String^>^ years2 = employees[j]->Split('-');
			int start = Int32::Parse(years2[0]);
			int end = Int32::Parse(years2[1]);
			if (startDate <= start && endDate >= start ||
				startDate <= end && endDate >= end ||
				startDate <= start && endDate >= end ||
				startDate >= start && endDate <= end)
			{
				combined[i] += combined[i] == 0 ? 2 : 1;
				combined[j] += combined[j] == 0 ? 2 : 1;
			}
		}
	}

	int maxValue = 0;
	for (int i = 0; i < employees->Length; i++)
		if (combined[i] > maxValue) maxValue = combined[i];

	return maxValue;
}
