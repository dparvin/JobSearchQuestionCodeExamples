using JobSearchCodeExamples.Support;

namespace JobSearchCodeExamples.cs.Contest
{
    /// <summary>
    /// LeetCode Contest 307
    /// </summary>
    /// <see href="https://leetcode.com/contest/weekly-contest-307/"/>
    public static class LeetCodeContest307
    {
        #region Minimum Hours of Training to Win a Competition ------

        /// <summary>
        /// Minimums the number of hours.
        /// </summary>
        /// <param name="initialEnergy">The initial energy.</param>
        /// <param name="initialExperience">The initial experience.</param>
        /// <param name="energy">The energy.</param>
        /// <param name="experience">The experience.</param>
        /// <returns></returns>
        /// <remarks>
        /// 2383. Minimum Hours of Training to Win a Competition
        /// 
        /// You are entering a competition, and are given two positive integers 
        /// initialEnergy and initialExperience denoting your initial energy and 
        /// initial experience respectively.
        /// 
        /// You are also given two 0-indexed integer arrays energy and experience, 
        /// both of length n.
        /// 
        /// You will face n opponents in order.The energy and experience of the ith 
        /// opponent is denoted by energy[i] and experience[i] respectively. When 
        /// you face an opponent, you need to have both strictly greater experience 
        /// and energy to defeat them and move to the next opponent if available.
        /// 
        /// Defeating the ith opponent increases your experience by experience[i], 
        /// but decreases your energy by energy[i].
        /// 
        /// Before starting the competition, you can train for some number of hours.
        /// After each hour of training, you can either choose to increase your 
        /// initial experience by one, or increase your initial energy by one.
        /// 
        /// Return the minimum number of training hours required to defeat all n 
        /// opponents.
        /// </remarks>
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
        /// Largest the palindromic.
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
                if (digits.TryGetValue(digit, out var value))
                    digits[digit] = ++value;
                else
                    digits.Add(digit, 1);
            }
            bool good = true;
            var digitsKeys = digits.Keys.ToArray();
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
                ending = new string([.. start.Reverse()]);
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
        public static int AmountOfTime(
            TreeNode? root,
            int start)
        {
            if (root == null)
                return 0;
            Dictionary<TreeNode, TreeNode?> parents = [];
            TreeNode? startNode = null;
            parents.Add(root, null);
            BuildTree(root, parents, ref startNode, start);

            return BFS(startNode, parents);
        }

        private static void BuildTree(
            TreeNode? node,
            Dictionary<TreeNode, TreeNode?> parents,
            ref TreeNode? startNode,
            int startValue)
        {
            if (node != null)
            {
                if (node.val == startValue)
                    startNode = node;

                if (node.left != null)
                {
                    parents[node.left] = node;
                    BuildTree(node.left, parents, ref startNode, startValue);
                }

                if (node.right != null)
                {
                    parents[node.right] = node;
                    BuildTree(node.right, parents, ref startNode, startValue);
                }
            }
        }

        /// <summary>
        /// BFSs the specified start node.
        /// </summary>
        /// <param name="startNode">The start node.</param>
        /// <param name="parents">The parents.</param>
        /// <returns></returns>
        private static int BFS(
            TreeNode? startNode,
            Dictionary<TreeNode, TreeNode?> parents)
        {
            if (startNode == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            HashSet<TreeNode> visited = [];
            queue.Enqueue(startNode);
            visited.Add(startNode);
            int time = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                bool infected = false;
                for (int i = 0; i < size; i++)
                {
                    TreeNode current = queue.Dequeue();
                    // Check left child
                    if (current.left != null && visited.Add(current.left))
                    {
                        queue.Enqueue(current.left);
                        infected = true;
                    }

                    // Check right child
                    if (current.right != null && visited.Add(current.right))
                    {
                        queue.Enqueue(current.right);
                        infected = true;
                    }

                    // Check parent
                    if (parents.TryGetValue(current, out TreeNode? parent) &&
                        parent != null &&
                        visited.Add(parent))
                    {
                        queue.Enqueue(parent);
                        infected = true;
                    }
                }
                if (infected)
                    time++;
            }
            return time;
        }

        #endregion

        #region Find the K-Sum of an Array --------------------------

        /// <summary>
        /// Finds the k-sum of an array.
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        /// <returns></returns>
        public static long KSum(int[] nums, int k)
        {
            var maxSum = (from num in nums select (long)num).Sum(x => Math.Max(0, x));

            for (var i = 0; i < nums.Length; i++)
                nums[i] = Math.Abs(nums[i]);

            Array.Sort(nums);
            Array.Reverse(nums); // Descending Order

            var n = nums.Length;
            var sums = Array.Empty<long>();
            AddToArray(ref sums, maxSum);
            for (var i = 0; i < n; i++)
            {
                var m = sums.Length;
                var numValue = nums[i];
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

        /// <summary>
        /// Adds to array.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="item">The item.</param>
        private static void AddToArray(ref long[] a, long item)
        {
            a ??= [];
            Array.Resize(ref a, a.Length + 1);
            a[^1] = item;
        }

        /// <summary>
        /// ks the sum2.
        /// </summary>
        /// <param name="nums">The nums.</param>
        /// <param name="k">The k.</param>
        /// <returns></returns>
        /// <remarks>
        /// This method finds the k-th largest sum of a subsequence from the input array.
        /// </remarks>
        public static long KSum2(int[] nums, int k)
        {
            // Get the length of the input array
            var n = nums.Length;
            // Calculate the total sum of non-negative numbers in the array
            var totalSum = (from num in nums select (long)num).Sum(x => Math.Max(0, x));

            // Every subsequence sum can be represented as:
            //
            //     maximum positive sum - reduction
            //
            // The reduction is the sum of the absolute values of the numbers that are
            // either removed (positive numbers) or included (negative numbers).
            // Converting everything to absolute values lets us search reductions instead
            // of all possible subsequence sums.
            for (var i = 0; i < nums.Length; i++)
                nums[i] = Math.Abs(nums[i]);

            Array.Sort(nums); // Sort the array in ascending order

            PriorityQueue<(long sum, int index), long> pq = new PriorityQueue<(long sum, int index), long>();
            // Each queue entry represents a reduction from the maximum subsequence sum.
            //
            // sum   = total reduction accumulated so far
            // index = next position that may be considered
            //
            // The queue is ordered by the smallest reduction first.
            pq.Enqueue((0, 0), 0);

            // The queue already contains the largest subsequence sum (reduction = 0).
            // After removing the first k-1 reductions, the smallest remaining reduction
            // corresponds to the k-th largest subsequence sum.
            for (int i = 1; i < k; i++)
            {
                // Dequeue the tuple with the smallest sum from the priority queue
                var (currentSum, index) = pq.Dequeue();
                // If the index is within the bounds of the array
                if (index < n)
                {
                    // Child #1:
                    // Keep the current reduction and also subtract nums[index].
                    //
                    // Example:
                    //   {2}  -> {2,5}
                    pq.Enqueue((currentSum + nums[index], index + 1), currentSum + nums[index]);
                    // If the index is greater than 0
                    if (index > 0)
                        // Child #2:
                        // Replace the previously chosen value with nums[index].
                        //
                        // Example:
                        //   {2} -> {5}
                        //
                        // currentSum already includes nums[index - 1], so we remove that value
                        // and replace it with nums[index]. This generates the next unique subset
                        // without creating duplicates.
                        pq.Enqueue((currentSum + nums[index] - nums[index - 1], index + 1), currentSum + nums[index] - nums[index - 1]);
                }
            }

            // Return the difference between the total sum of non-negative numbers and the smallest sum in the priority queue, which
            // represents the k-th largest sum
            return totalSum - pq.Peek().sum;
        }

        #endregion
    }
}
