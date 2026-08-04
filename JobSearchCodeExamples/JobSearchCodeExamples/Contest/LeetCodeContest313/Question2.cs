namespace JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

/// <summary>
/// 
/// </summary>
public static class Question2
{
    /// <summary>
    /// Determines the maximum sum of an hourglass in the grid.
    /// </summary>
    /// <param name="grid">The grid.</param>
    /// <returns>The maximum sum of an hourglass.</returns>
    /// <seealso href="https://leetcode.com/problems/maximum-sum-of-an-hourglass/description/"/>
    public static int MaxSum(int[][] grid)
    {
        int maxSum = int.MinValue;
        for (int i = 0; i < grid.Length - 2; i++)
        {
            for (int j = 0; j < grid[i].Length - 2; j++)
            {
                maxSum = Math.Max(maxSum, CalculateHourglassSum(grid, i, j));
            }
        }
        return maxSum;
    }

    /// <summary>
    /// Calculates the hourglass sum.
    /// </summary>
    /// <param name="grid">The grid.</param>
    /// <param name="top">The top.</param>
    /// <param name="left">The left.</param>
    /// <returns></returns>
    private static int CalculateHourglassSum(int[][] grid, int top, int left)
    {
        return grid[top][left] + grid[top][left + 1] + grid[top][left + 2] +
                                 grid[top + 1][left + 1] +
               grid[top + 2][left] + grid[top + 2][left + 1] + grid[top + 2][left + 2];
    }
}
