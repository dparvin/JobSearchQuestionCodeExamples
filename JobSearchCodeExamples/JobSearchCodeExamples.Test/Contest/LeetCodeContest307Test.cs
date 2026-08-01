using JobSearchCodeExamples.cs.Contest;
using JobSearchCodeExamples.Support;

namespace JobSearchCodeExamples.cs.Test.Contest
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
        [MemberData(nameof(MinNumberOfHoursTestData))]
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
        [MemberData(nameof(AmountOfTimeTestData))]
        public void AmountOfTimeTest(int?[] nodes, int start, int expectedResult)
        {
            var root = TreeNodeHelper.BuildTree(nodes);

            Assert.Equal(expectedResult, LeetCodeContest307.AmountOfTime(root, start));
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
            Assert.Equal(expectedResult, LeetCodeContest307.KSum(nums, k));
        }

        /// <summary>
        /// k sum test.
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        /// <param name="expectedResult">The expected result.</param>
        [Theory]
        [MemberData(nameof(KSumTestData))]
        public void KSum2Test(int[] nums, int k, long expectedResult)
        {
            Assert.Equal(expectedResult, LeetCodeContest307.KSum2(nums, k));
        }

        #endregion
    }
}
