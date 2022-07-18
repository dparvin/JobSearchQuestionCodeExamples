namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// Custom code to do processes
/// </summary>
public static class CustomCode
{
    /// <summary>
    /// Versions the compare.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static int VersionCompare(string version1, string version2)
    {
        string[] v1 = version1.Split('.');
        string[] v2 = version2.Split('.');
        int longest = v1.Length < v2.Length ? v2.Length : v1.Length;
        for (int i = 0; i < longest; i++)
        {
            int item1 = 0;
            int item2 = 0;
            if (i < v1.Length) item1 = int.Parse(v1[i], CultureInfo.InvariantCulture);
            if (i < v2.Length) item2 = int.Parse(v2[i], CultureInfo.InvariantCulture);
            int result = item1 < item2 ? -1 : item1 > item2 ? 1 : 0;
            if (result != 0) return result;
        }
        return 0;
    }

    /// <summary>
    /// Versions the compare.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static int LongVersionCompare(string version1, string version2)
    {
        var v1 = new LongVersion(version1);
        var v2 = new LongVersion(version2);

        return v1.CompareTo(v2);
    }

    /// <summary>
    /// Finds the missing entry.
    /// </summary>
    /// <param name="values">The array of integers that is missing an item.</param>
    /// <returns></returns>
    /// <remarks>
    /// This function only works when there is only one item missing in the array.  If
    /// there are more than one then the return will be a sum of the two missing items.
    /// </remarks>
    public static int FindMissingEntry(int[] values)
    {
        return ((values.Length + 1) * (values.Length + 2) / 2) - values.Sum();
    }
}
