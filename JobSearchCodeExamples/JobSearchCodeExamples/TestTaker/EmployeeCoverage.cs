using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// Routines to calculate employee coverage
/// </summary>
public static class EmployeeCoverage
{
    /// <summary>
    /// Maximums the coverage.
    /// </summary>
    /// <param name="employees">The employees.</param>
    /// <returns></returns>
    public static int MaxCoverage(string[] employees)
    {
        int[] combined = new int[employees.Length];

        for (int i = 0; i < employees.Length; i++)
        {
            string[] years = employees[i].Split("-");
            int startDate = int.Parse(years[0]);
            int endDate = int.Parse(years[1]);
            for (int j = i + 1; j < employees.Length; j++)
            {
                string[] years2 = employees[j].Split("-");
                int start = int.Parse(years2[0]);
                int end = int.Parse(years2[1]);
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
        var maxValue = 0;
        for (int i = 0; i < employees.Length; i++)
            if (combined[i] > maxValue) maxValue = combined[i];

        return maxValue;
    }
}
