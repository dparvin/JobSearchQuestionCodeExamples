using JobSearchCodeExamples.Contest;
using JobSearchCodeExamples.Support;
using static JobSearchCodeExamples.Contest.LeetCodeContest307;

namespace JobSearchCodeExamples.Test.Contest
{
    /// <summary>
    /// Represents the test class for LeetCode Contest 307 problems.
    /// </summary>
    public partial class LeetCodeContest307Test
    {
        #region Minimum Hours of Training to Win a Competition ------

        /// <summary>
        /// Minimums the number of hours test.
        /// </summary>
        /// <param name="initialEnergy">The initial energy.</param>
        /// <param name="initialExperience">The initial experience.</param>
        /// <param name="energy">The energy.</param>
        /// <param name="experience">The experience.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [InlineData(5, 3, new int[] { 1, 4, 3, 2 }, new int[] { 2, 6, 4, 1 }, 8)]
        [InlineData(5, 3, new int[] { 1, 4 }, new int[] { 2, 5 }, 2)]
        [InlineData(2, 4, new int[] { 1 }, new int[] { 3 }, 0)]
        [InlineData(1, 1, new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 50 }, 51)]
        [InlineData(30, 178, new int[] { 24, 91, 63, 38, 31, 63, 22, 35, 91, 54, 88, 46, 80, 14, 12, 19, 57, 92 }, new int[] { 18, 43, 36, 88, 84, 21, 82, 54, 61, 80, 68, 54, 75, 27, 99, 14, 86, 95 }, 891)]
        [InlineData(58, 100, new int[] { 64, 93, 52, 26, 1, 39, 7, 2, 80, 80 }, new int[] { 52, 36, 68, 32, 71, 86, 53, 57, 92, 50 }, 387)]
        [InlineData(43, 76, new int[] { 11, 65, 22 }, new int[] { 85, 29, 22 }, 66)]
        public void MinNumberOfHoursTest(int initialEnergy, int initialExperience, int[] energy, int[] experience, int expectedResult)
        {
            Assert.Equal(expectedResult, LeetCodeContest307.MinNumberOfHours(initialEnergy, initialExperience, energy, experience));
        }

        #endregion

        #region Largest Palindromic Number --------------------------

        /// <summary>
        /// The largest palindromic test.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [InlineData("444947137", "7449447")]
        [InlineData("00009", "9")]
        [InlineData("00001105", "1005001")]
        [InlineData("00000", "0")]
        public void LargestPalindromic1Test(string num, string expectedResult)
        {
            Assert.Equal(expectedResult, LeetCodeContest307.LargestPalindromic(num));
        }

        /// <summary>
        /// The largest palindromic test.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [InlineData("444947137", "7449447")]
        [InlineData("00009", "9")]
        [InlineData("00001105", "1005001")]
        [InlineData("00000", "0")]
        public void LargestPalindromic2Test(string num, string expectedResult)
        {
            Assert.Equal(expectedResult, LeetCodeContest307.LargestPalindromic2(num));
        }

        #endregion

        #region Amount of Time for Binary Tree to Be Infected -------

        /// <summary>
        /// Amounts the of time test.
        /// </summary>
        /// <param name="nodes">The nodes.</param>
        /// <param name="start">The start.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [InlineData(new int[] { 1, 5, 3, 0, 4, 10, 6, 9, 2 }, 3, 4)]
        [InlineData(new int[] { 1 }, 1, 0)]
        public void AmountOfTimeTest(int[] nodes, int start, int expectedResult)
        {
            var root = TreeNodeHelper.BuildTree(nodes);

            Assert.Equal(expectedResult, AmountOfTime(root, start));
        }

        #endregion

        #region Find the K-Sum of an Array --------------------------

        /// <summary>
        /// k sum test.
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [MemberData(nameof(KSumTestData))]
        public void KSumTest(int[] nums, int k, long expectedResult)
        {
            Assert.Equal(expectedResult, KSum(nums, k));
        }

        #endregion
    }
}
