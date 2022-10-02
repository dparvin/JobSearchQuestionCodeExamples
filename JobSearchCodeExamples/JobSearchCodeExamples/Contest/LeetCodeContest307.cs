namespace JobSearchCodeExamples.Contest
{
    /// <summary>
    /// LeetCode Contest 307
    /// </summary>
    public static class LeetCodeContest307
    {
        #region Minimum Hours of Training to Win a Competition ------

        /// <summary>
        /// Question 1.
        /// </summary>
        /// <param name="initialEnergy">The initial energy.</param>
        /// <param name="initialExperience">The initial experience.</param>
        /// <param name="energy">The energy.</param>
        /// <param name="experience">The experience.</param>
        /// <returns></returns>
        public static int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var neededEnergy = energy.Sum() + 1;
            var trainedEnergy = Math.Max(neededEnergy - initialEnergy, 0);
            var neededExperience = initialExperience;
            var trainedExerience = 0;
            if (experience != null)
            {
                for (int i = 0; i < experience.Length; i++)
                    if (neededExperience > experience[i])
                        neededExperience += experience[i];
                    else
                    {
                        trainedExerience += experience[i] - neededExperience + 1;
                        neededExperience += experience[i] - neededExperience + 1 + experience[i];
                    }
            }
            return trainedEnergy + trainedExerience;
        }

        #endregion

        #region Largest Palindromic Number --------------------------

        /// <summary>
        /// Question 2.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns></returns>
        public static string LargestPalindromic(string num)
        {
            var digits = new Dictionary<int, int>();
            string start = string.Empty;
            string ending = string.Empty;

            for (int i = 0; i < num.Length; i++)
            {
                var digit = Convert.ToInt32(num[i].ToString());
                if (digits.ContainsKey(digit))
                    digits[digit]++;
                else
                    digits.Add(digit, 1);
            }
            bool good = true;
            int[] digitsKeys = digits.Keys.ToArray();
            int largest;
            var first = true;
            while (good)
            {
                largest = -1;
                for (int i = 0; i < digitsKeys.Length; i++)
                    if (digitsKeys[i] > largest && digits[digitsKeys[i]] > 1)
                        largest = digitsKeys[i];
                if (largest == -1)
                    good = false;
                else if ((first && largest != 0) || !first)
                {
                    first = false;
                    while (digits[largest] > 1)
                    {
                        start += largest.ToString();
                        ending = largest.ToString() + ending.ToString();
                        digits[largest] -= 2;
                    }
                }
                else
                    good = false;
            }
            largest = -1;
            for (int i = 0; i < digitsKeys.Length; i++)
                if (digitsKeys[i] > largest && digits[digitsKeys[i]] > 0)
                    largest = digitsKeys[i];
            if (largest != -1)
                start += largest.ToString();

            return start + ending;
        }

        /// <summary>
        /// Question 2.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns></returns>
        public static string LargestPalindromic2(string num)
        {
            var map = new int[10];
            string start = string.Empty;

            for (int i = 0; i < num.Length; i++)
                map[num[i] - '0']++;
            for (int i = 9; i > -1; i--)
            {
                if (i == 0 && string.IsNullOrEmpty(start)) break;
                if (map[i] > 1)
                {
                    start += new string(i.ToString().ToCharArray()[0], map[i] / 2);
                    map[i] = map[i] % 2;
                }
            }
            string ending = string.Empty;
            if (!string.IsNullOrEmpty(start))
                ending = new string(start.Reverse().ToArray());
            for (int i = 9; i > -1; i--)
                if (map[i] > 0)
                {
                    start += i.ToString();
                    break;
                }

            return start + ending;
        }

        #endregion

        #region Amount of Time for Binary Tree to Be Infected -------

        /// <summary>
        /// Question 3.
        /// </summary>
        public static int AmountOfTime(TreeNode root, int start)
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public class TreeNode
        {
            /// <summary>
            /// The value
            /// </summary>
            public int val;
            /// <summary>
            /// The position
            /// </summary>
            public int pos;
            /// <summary>
            /// The left
            /// </summary>
            public TreeNode? left;
            /// <summary>
            /// The right
            /// </summary>
            public TreeNode? right;
            /// <summary>
            /// Initializes a new instance of the <see cref="TreeNode" /> class.
            /// </summary>
            /// <param name="val">The value.</param>
            /// <param name="pos">The position.</param>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            public TreeNode(int val = 0, int pos = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.pos = pos;
                this.left = left;
                this.right = right;
            }
        }

        #endregion

        #region Find the K-Sum of an Array --------------------------

        /// <summary>
        /// Question 4.
        /// </summary>
        public static long KSum(int[] nums, int k)
        {
            Array.Sort(nums);
            Array.Reverse(nums); // Descending Order
            var maxSum = (from num in nums select (long)num).Sum(x => Math.Max(0, x));
            var n = nums.Length;
            var sums = new long[] { };
            AddToArray(ref sums, maxSum);
            for (var i = 0; i < n; i++)
            {
                var m = sums.Length;
                var numValue = Math.Abs(nums[i]);
                if (m >= k && maxSum - numValue < sums[m - 1]) break;
                for (var j = 0; j < m; j++)
                {
                    var value = sums[j] - numValue;
                    if (m <= k || value > sums[m - 1])
                        AddToArray(ref sums, value);
                    else
                        break;
                }
                if (sums.Length > k)
                {
                    Array.Sort(sums);
                    Array.Reverse(sums);
                    Array.Resize(ref sums, k);
                }
            }
            while (sums.Length < k)
                AddToArray(ref sums, 0);
            Array.Sort(sums);
            Array.Reverse(sums);
            return sums[^1];
        }

        private static void AddToArray(ref long[] a, long item)
        {
            a ??= Array.Empty<long>();
            Array.Resize(ref a, a.Length + 1);
            a[^1] = item;
        }

        #endregion
    }
}
