using JobSearchCodeExamples.Contest;
using static JobSearchCodeExamples.Contest.LeetCodeContest307;

namespace JobSearchCodeExamples.Test.Contest
{
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
        [InlineData(2, 4, new int[] { 1 }, new int[] { 3 }, 0)]
        [InlineData(100, 100, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 10 }, 0)]
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
            var root = new TreeNode(nodes[0]);
            var Index = 1;
            var pos = 1;
            while (Index < nodes.Length)
            {
                AddBranchs(ref root, nodes, pos, ref Index);
                pos++;
            }

            Assert.Equal(expectedResult, AmountOfTime(root, start));
        }

        private static void AddBranchs(ref TreeNode? parent, int[] nodes, int pos, ref int index, int currLevel = 0)
        {
            var posLevel = (int)Math.Pow(pos, .5);
            var posLeft = Math.Round((pos - ((int)Math.Pow(2, posLevel)-1.0)) / (int)Math.Pow(posLevel, 2), 0);
            if (parent == null && posLevel == currLevel && nodes[index] != 0)
            {
                parent = new TreeNode(nodes[index], pos);
                index++;
            }
            else if (parent == null && posLevel == currLevel && nodes[index] == 0)
                index++;
            else if (parent != null && posLeft == 0)
                AddBranchs(ref parent.left, nodes, pos, ref index, currLevel + 1);
            else if (parent != null && posLeft == 1)
                AddBranchs(ref parent.right, nodes, pos, ref index, currLevel + 1);
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
