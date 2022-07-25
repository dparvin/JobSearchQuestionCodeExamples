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
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);
        if (v1 is null) if (v2 is null) return 0; else return -1;

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

    /// <summary>
    /// Longs the version equal.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionEqual(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 == v2;
    }

    /// <summary>
    /// the version is the same object.
    /// </summary>
    /// <param name="version">The version.</param>
    /// <returns></returns>
    public static bool LongVersionEqualSame(string version)
    {
        LongVersion? v = null;
        if (!string.IsNullOrEmpty(version)) v = new LongVersion(version);

#pragma warning disable CS1718 // Comparison made to same variable
        return v == v;
#pragma warning restore CS1718 // Comparison made to same variable
    }

    /// <summary>
    /// Get the hash code for the version.
    /// </summary>
    /// <returns></returns>
    public static int LongVersionGetHashCode()
    {
        var v = new LongVersion("2.0.0.1");

        return v.GetHashCode();
    }

    /// <summary>
    /// Get the string version of the version.
    /// </summary>
    /// <returns></returns>
    public static String LongVersionToString()
    {
        var v = new LongVersion("2.0.0.1");

        return v.ToString();
    }

    /// <summary>
    /// Longs the version equal.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionNotEqual(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 != v2;
    }

    /// <summary>
    /// Longs the version equal.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionGreater(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 > v2;
    }

    /// <summary>
    /// Compare two long version numbers using Greater Than or equal to.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionGreaterEqual(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 >= v2;
    }

    /// <summary>
    /// Compare two long version numbers using Less Than.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionLess(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 < v2;
    }

    /// <summary>
    /// Compare two long version numbers using Less Than or equal to.
    /// </summary>
    /// <param name="version1">The version1.</param>
    /// <param name="version2">The version2.</param>
    /// <returns></returns>
    public static bool LongVersionLessEqual(string version1, string version2)
    {
        LongVersion? v1 = null;
        LongVersion? v2 = null;
        if (!string.IsNullOrEmpty(version1)) v1 = new LongVersion(version1);
        if (!string.IsNullOrEmpty(version2)) v2 = new LongVersion(version2);

        return v1 <= v2;
    }
}
