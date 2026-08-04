namespace JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

/// <summary>
/// This class contains a method to determine the number of common factors between two integers.
/// </summary>
public static class Question1
{
    /// <summary>
    /// Determines the number of common factors between two integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <param name="log">The log action.</param>
    /// <returns></returns>
    /// <see href="https://leetcode.com/problems/number-of-common-factors/description/" />
    public static int CommonFactors(int a, int b, Action<string>? log = null)
    {
        log?.Invoke($"Calculating common factors for a = {a}, b = {b}");
        int count = 0;
        int min = Math.Min(a, b);
        for (int i = 1; i <= min; i++)
            if (a % i == 0 && b % i == 0)
            {
                log?.Invoke($"Found common factor: {i}");
                count++;
            }
        log?.Invoke($"Total common factors: {count}");
        return count;
    }
}
