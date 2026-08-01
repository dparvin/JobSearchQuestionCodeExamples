namespace JobSearchCodeExamples.cs.Contest;

/// <summary>
/// Routines for contest questions for LeetCode Contest 309
/// </summary>
/// <see href="https://leetcode.com/contest/weekly-contest-309/"/>
public static class LeetCodeContest309
{
    #region Check Distances Between Same Letters --------------------

    /// <summary>
    /// Checks the distances between same letters in the string.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <param name="distance">The distance.</param>
    /// <returns></returns>
    public static bool CheckDistances(string s, int[] distance)
    {
        foreach (var letter in s.ToCharArray())
        {
            int letterIndex = letter - 'a';
            int index1 = s.IndexOf(letter);
            int index2 = s.IndexOf(letter, index1 + 1);
            if (index2 - index1 - 1 != distance[letterIndex])
                return false;
        }
        return true;
    }

    #endregion

    #region Number of Ways to Reach a Position After Exactly k Steps

    /// <summary>
    /// Question2s the specified value.
    /// </summary>
    /// <param name="startPos">The start position.</param>
    /// <param name="endPos">The end position.</param>
    /// <param name="k">The number of steps between start and end.</param>
    /// <returns></returns>
    public static int NumberOfWays(int startPos, int endPos, int k)
    {
        if (endPos - startPos > k)
            return 0;
        int[][] dp = new int[k * 2 + 1][];
        for (int i = 0; i < k * 2 + 1; i++)
            dp[i] = new int[k * 2 + 1];

        return Distance(dp, k, Math.Abs(startPos - endPos));
    }

    /// <summary>
    /// Distance to the specified distance point.
    /// </summary>
    /// <param name="dp">The distance points array.</param>
    /// <param name="k">The number of points between start and end.</param>
    /// <param name="d">The distance between start and end.</param>
    /// <returns></returns>
    private static int Distance(int[][] dp, int k, int d)
    {
        const int mod = 1000000007;
        if (d >= k)
            return d == k ? 1 : 0;
        if (dp[k][d] == 0)
            dp[k][d] = (1 + (Distance(dp, k - 1, d + 1) + Distance(dp, k - 1, Math.Abs(d - 1)))) % mod;

        return Math.Abs(dp[k][d] - 1);
    }

    #endregion

    #region Longest Nice Sub-array ----------------------------------

    /// <summary>
    /// Question 3s Longest Nice SubArray.
    /// </summary>
    /// <param name="nums">The numbers to process.</param>
    /// <returns></returns>
    public static int LongestNiceSubArray(Int64[] nums)
    {
        int left = 0;
        Int64 usedBits = 0;
        int longest = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            // Remove elements from the left until nums[right]
            // does not share any bits with the current window.
            while ((usedBits & nums[right]) != 0)
            {
                usedBits ^= nums[left];
                left++;
            }

            // Add the new number into the window
            usedBits |= nums[right];

            // Track the longest valid window
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }

    #endregion

    #region Meeting Rooms III ---------------------------------------

    /// <summary>
    /// Room Data Types
    /// </summary>
    private enum RoomData : int
    {
        /// <summary>
        /// The next available time
        /// </summary>
        NextAvailableTime = 0,
        /// <summary>
        /// The meeting count
        /// </summary>
        MeetingCount = 1,
    }

    /// <summary>
    /// A meeting structure
    /// </summary>
    private readonly record struct Meeting(int Start, int End);

    /// <summary>
    /// Figure out the meeting room that had the most meetings
    /// </summary>
    /// <param name="n">The number of meeting rooms.</param>
    /// <param name="meetings">The meetings.</param>
    /// <returns></returns>
    /// <see href="https://leetcode.com/contest/weekly-contest-309/problems/meeting-rooms-iii/"/>
    /// <remarks>
    /// 2402. Meeting Rooms III
    /// 
    /// You are given an integer n.There are n rooms numbered from 0 to n - 1.
    /// 
    /// You are given a 2D integer array meetings where meetings[i] = [start[i], end[i]] means that a 
    /// meeting will be held during the half-closed time interval[start[i], end[i]). All the values of 
    /// start[i] are unique.
    /// 
    /// Meetings are allocated to rooms in the following manner:
    /// 
    /// 1. Each meeting will take place in the unused room with the lowest number.
    /// 2. If there are no available rooms, the meeting will be delayed until a room becomes free. The 
    ///    delayed meeting should have the same duration as the original meeting.
    /// 3. When a room becomes unused, meetings that have an earlier original start time should be given the room.
    /// 
    /// Return the number of the room that held the most meetings.If there are multiple rooms, return the room with the lowest number.
    /// 
    /// A half - closed interval[a, b) is the interval between a and b including a and not including b.
    /// </remarks>
    public static int MostBookedBruteForce(int n, int[][] meetings)
    {
        // **********************************************
        // * Sort the array by the meeting start time
        // **********************************************
        int[] startTimes = new int[meetings.Length];
        int[] endTimes = new int[meetings.Length];
        for (int i = 0; i < meetings.Length; i++)
        {
            startTimes[i] = meetings[i][0];
            endTimes[i] = meetings[i][1];
        }
        Array.Sort(startTimes, endTimes);

        // **********************************************
        // 8uild Rooms [room number] [0 = next start time;
        //                            1 = number of meetings]
        // **********************************************
        long[][] rooms = new long[n][];

        for (int i = 0; i < n; i++)
            rooms[i] = new long[2];

        // **********************************************
        // Process the schedule
        // **********************************************
        for (int i = 0; i < meetings.Length; i++)
        {
            bool scheduled = false;
            for (int j = 0; j < n; j++)
            {
                if (startTimes[i] >= rooms[j][(int)RoomData.NextAvailableTime])
                {
                    if (rooms[j][(int)RoomData.NextAvailableTime] < startTimes[i])              // If the start time for the meeting is later than the next available time
                        rooms[j][(int)RoomData.NextAvailableTime] = startTimes[i];              // Set the next available time to the start time of the meeting
                    rooms[j][(int)RoomData.NextAvailableTime] += endTimes[i] - startTimes[i];   // Add the difference between the end time and the start time to get a new next time
                    rooms[j][(int)RoomData.MeetingCount]++;                                     // Increment the meeting count
                    scheduled = true;
                    break;
                }
            }
            if (!scheduled)
            {
                int earliest = 0;
                long earliestTime = long.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (rooms[j][(int)RoomData.NextAvailableTime] < earliestTime)
                    {
                        earliest = j;
                        earliestTime = rooms[j][(int)RoomData.NextAvailableTime];
                    }
                }
                rooms[earliest][(int)RoomData.NextAvailableTime] += endTimes[i] - startTimes[i];
                rooms[earliest][(int)RoomData.MeetingCount]++;
            }
        }

        // **********************************************
        // Figure out which room had the most meetings
        // **********************************************
        int result = 0;
        long MostMeetings = 0;
        for (var i = 0; i < n; i++)
            if (rooms[i][(int)RoomData.MeetingCount] > MostMeetings)
            {
                MostMeetings = rooms[i][(int)RoomData.MeetingCount];
                result = i;
            }

        return result;
    }

    /// <summary>
    /// Figure out the meeting room that had the most meetings
    /// </summary>
    /// <param name="n">The number of meeting rooms.</param>
    /// <param name="meetings">The meetings.</param>
    /// <returns></returns>
    /// <see href="https://leetcode.com/contest/weekly-contest-309/problems/meeting-rooms-iii/"/>
    /// <remarks>
    /// 2402. Meeting Rooms III
    /// 
    /// You are given an integer n.There are n rooms numbered from 0 to n - 1.
    /// 
    /// You are given a 2D integer array meetings where meetings[i] = [start[i], end[i]] means that a 
    /// meeting will be held during the half-closed time interval[start[i], end[i]). All the values of 
    /// start[i] are unique.
    /// 
    /// Meetings are allocated to rooms in the following manner:
    /// 
    /// 1. Each meeting will take place in the unused room with the lowest number.
    /// 2. If there are no available rooms, the meeting will be delayed until a room becomes free. The 
    ///    delayed meeting should have the same duration as the original meeting.
    /// 3. When a room becomes unused, meetings that have an earlier original start time should be given the room.
    /// 
    /// Return the number of the room that held the most meetings.If there are multiple rooms, return the room with the lowest number.
    /// 
    /// A half - closed interval[a, b) is the interval between a and b including a and not including b.
    /// </remarks>
    public static int MostBookedPriorityQueue(int n, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));
        PriorityQueue<int, int> availableRooms = new();
        for (int roomNumber = 0; roomNumber < n; roomNumber++)
            availableRooms.Enqueue(roomNumber, roomNumber);

        PriorityQueue<(int Room, long AvailableTime), (long AvailableTime, int Room)> busyRooms = new();
        int[] meetingCount = new int[n];
        foreach (var meeting in meetings)
        {
            var currentMeeting = new Meeting(meeting[0], meeting[1]);

            while (busyRooms.Count > 0 && busyRooms.Peek().AvailableTime <= currentMeeting.Start)
            {
                var (Room, AvailableTime) = busyRooms.Dequeue();
                availableRooms.Enqueue(Room, Room);
            }

            if (availableRooms.Count > 0)
            {
                int room = availableRooms.Dequeue();

                busyRooms.Enqueue(
                    (room, currentMeeting.End),
                    (currentMeeting.End, room));

                meetingCount[room]++;
            }
            else
            {
                var (Room, AvailableTime) = busyRooms.Dequeue();

                long newEnd = AvailableTime + (currentMeeting.End - currentMeeting.Start);

                busyRooms.Enqueue(
                    (Room, newEnd),
                    (newEnd, Room));

                meetingCount[Room]++;
            }
        }

        int bestRoom = 0;

        for (int i = 1; i < n; i++)
        {
            if (meetingCount[i] > meetingCount[bestRoom])
                bestRoom = i;
        }

        return bestRoom;
    }

    // Two implementations are provided for comparison.
    //
    // The brute force implementation performs a linear scan of the rooms for each
    // meeting. Given this problem's constraint of at most 100 rooms, it is simple,
    // easy to understand, and was actually faster than the priority queue solution
    // in my LeetCode benchmarks.
    //
    // The priority queue implementation has better asymptotic complexity
    // (O(m log n) versus O(m × n)) and scales better as the number of rooms grows.
    // For much larger values of n, it would be expected to outperform the brute
    // force approach.

    #endregion
}
