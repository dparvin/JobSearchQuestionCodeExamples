using System.Text;

namespace JobSearchCodeExamples.Contest;

/// <summary>
/// LeetCode Contest 308
/// </summary>
public static class LeetCodeContest308
{
    #region Longest Subsequence With Limited Sum --------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public static int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        int[] result = new int[queries.Length];
        for (var i = 0; i < result.Length; i++)
        {
            var sum = 0;
            var count = 0;
            for (var j = 0; j < nums.Length; j++)
            {
                if (sum + nums[j] <= queries[i])
                {
                    sum += nums[j];
                    count++;
                }
            }
            result[i] = count;
        }
        return result;
    }

    #endregion

    #region Question 2 ------------------------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public static string RemoveStars1(string s)
    {
        var result = s;
        var index = result.IndexOf("*");
        var count = 1;
        while (index > -1)
        {
            for (int i = index + 1; i < result.Length; i++)
                if (result[i] == '*')
                    count++;
                else
                    break;
            if (index == 0)
                result = s.Remove(0, count);
            else
            {
                var subindex = index - count;
                var sub = result.Substring(subindex, count * 2);
                result = result.Replace(sub, "");
                subindex = result.IndexOf(sub);
                while (subindex > -1)
                {
                    result = result.Remove(subindex, count * 2);
                    subindex = result.IndexOf(sub);
                }
            }
            index = result.IndexOf("*");
            count = 1;
        }
        return result;
    }

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public static string RemoveStars2(string s)
    {
        var result = new StringBuilder();
        var index = 0;
        while (index < s.Length)
        {
            var chr = s[index];
            if (chr == '*')
                result.Remove(result.Length - 1, 1);
            else
                result.Append(chr);
            index++;
        }
        return result.ToString();
    }

    #endregion

    #region Minimum Amount of Time to Collect Garbage ---------------

    /// <summary>
    /// Garbages the collection.
    /// </summary>
    /// <param name="garbage">The garbage.</param>
    /// <param name="travel">The travel.</param>
    /// <returns></returns>
    public static int GarbageCollection1(string[] garbage, int[] travel)
    {
        int result = 0;
        var trucks = new char[] { 'M', 'P', 'G' };
        foreach (var truck in trucks)
        {
            var time = 0;
            var skipped = 0;
            for (int i = 0; i < garbage.Length; i++)
            {
                if (i > 0)
                    skipped += travel[i - 1];
                if (garbage[i].Contains(truck))
                {
                    for (int j = 0; j < garbage[i].Length; j++)
                    {
                        if (garbage[i].ToCharArray()[j] == truck)
                        {
                            time += 1 + skipped;
                            skipped = 0;
                        }
                    }
                }
            }
            result += time;
        }
        return result;
    }

    /// <summary>
    /// Garbages the collection.
    /// </summary>
    /// <param name="garbage">The garbage.</param>
    /// <param name="travel">The travel.</param>
    /// <returns></returns>
    public static int GarbageCollection2(string[] garbage, int[] travel)
    {
        int result;
        char[] trucks = { 'M', 'P', 'G' };
        int[][] count = new int[garbage.Length][];
        for (var i = 0; i < garbage.Length; i++)
        {
            count[i] = new int[3];
            var items = garbage[i].ToCharArray();
            for (var j = 0; j < items.Length; j++)
                for (var t = 0; t < trucks.Length; t++)
                    if (items[j] == trucks[t]) count[i][t]++;
        }
        result = count[0][0] + count[0][1] + count[0][2];
        for (var j = 0; j < 3; j++)
        {
            var flag = false;
            for (var i = garbage.Length - 1; i > 0; i--)
            {
                if (count[i][j] > 0)
                {
                    result += travel[i - 1] + count[i][j];
                    flag = true;
                }
                else
                    result += flag ? travel[i - 1] : 0;
            }
        }
        return result;
    }

    #endregion

    #region Build a Matrix With Conditions --------------------------

    /// <summary>
    /// </summary>
    /// <returns></returns>
    public static int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions)
    {
        var result = new int[k][];
        var rowsMap = new Dictionary<int, List<int>>();
        var colsMap = new Dictionary<int, List<int>>();
        var rowsDeps = new Dictionary<int, List<int>>();
        var colsDeps = new Dictionary<int, List<int>>();

        for (var i = 0; i < k; i++)
        {
            result[i] = new int[k];
            rowsMap.Add(i, new List<int>());
            colsMap.Add(i, new List<int>());
            rowsDeps.Add(i, new List<int>());
            colsDeps.Add(i, new List<int>());
        }
        Data(rowConditions, rowsMap, rowsDeps);
        Data(colConditions, colsMap, colsDeps);

        var rows = new int[k];
        var cols = new int[k];

        if (!Build(k, rowsMap, rowsDeps, rows) ||
            !Build(k, colsMap, colsDeps, cols)) return new int[0][];

        for (var i = 0; i < k; i++)
            result[rows[i]][cols[i]] = i + 1;

        return result;
    }

    private static void Data(
        int[][] conditions,
        Dictionary<int, List<int>> map,
        Dictionary<int, List<int>> deps)
    {
        for (var i = 0; i < conditions.Length; i++)
        {
            map[conditions[i][0] - 1].Add(conditions[i][1] - 1);
            deps[conditions[i][1] - 1].Add(conditions[i][0] - 1);
        }
    }

    private static bool Build(
        int k,
        Dictionary<int, List<int>> map,
        Dictionary<int, List<int>> deps,
        int[] result)
    {
        var q = new Queue<int>();
        foreach (var (num, dp) in deps)
            if (dp.Count == 0) q.Enqueue(num);

        if (q.Count == 0) return false;

        var index = 0;
        while (q.Count > 0)
        {
            var curr = q.Dequeue();
            result[curr] = index;
            foreach (var next in map[curr])
            {
                deps[next].Remove(curr);
                if (deps[next].Count == 0) q.Enqueue(next);
            }
            index++;
        }

        return index == k;
    }

    #endregion
}
