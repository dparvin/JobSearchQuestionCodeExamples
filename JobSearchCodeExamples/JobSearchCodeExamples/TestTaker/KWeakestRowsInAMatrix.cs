namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// Routines to get a list of the weakest battalion in a matrix
/// </summary>
public static class KWeakestRowsInAMatrix
{
    /// <summary>
    /// the k weakest rows from the matrix.
    /// </summary>
    /// <param name="mat">The mat.</param>
    /// <param name="k">The k.</param>
    /// <returns></returns>
    public static int[] KWeakestRows(int[][] mat, int k)
    {
        var indicies = new Dictionary<int, int>();
        for (var i = 0; i < mat.Length; i++)
        {
            int solders = 0;
            for (var j = 0; j < mat[i].Length; j++)
                if (mat[i][j] == 1) solders++;
            indicies.Add(i, solders);
        }
        var result = indicies.ToArray();
        Array.Sort(result, (item1, item2) => Compare(item1, item2));
        var ret = new int[k];
        for (var i = 0; i < k; i++)
            ret[i] = result[i].Key;
        return ret;
    }

    /// <summary>
    /// Compares the specified i1.
    /// </summary>
    /// <param name="i1">The i1.</param>
    /// <param name="i2">The i2.</param>
    /// <returns></returns>
    private static int Compare(KeyValuePair<int, int> i1, KeyValuePair<int, int> i2)
    {
        int result = i1.Value.CompareTo(i2.Value);

        if (result == 0)
            result = i1.Key.CompareTo(i2.Key);

        return result;
    }
}
