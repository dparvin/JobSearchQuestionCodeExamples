namespace JobSearchCodeExamples.cs.TestTaker
{
    /// <summary>
    /// Assign the theater seats.
    /// </summary>
    public class TheaterSeats
    {
        /// <summary>
        /// Assigns the seats.
        /// </summary>
        /// <param name="seatsAssign">The seats assign.</param>
        /// <param name="seatsRequested">The seats requested.</param>
        /// <returns></returns>
        public static int[] AssignSeats(ref int[] seatsAssign, int[] seatsRequested)
        {
            List<int> results = [];
            List<int> usedSeats = [.. seatsAssign];
            foreach (int seat in seatsRequested)
            {
                int nextAvailableSeat = FindNextAvailableSeat(usedSeats, seat);
                results.Add(nextAvailableSeat);
                usedSeats.Add(nextAvailableSeat);
            }

            seatsAssign = [.. usedSeats];
            return [.. results];
        }

        /// <summary>
        /// Finds the next available seat.
        /// </summary>
        /// <param name="usedSeats">The used seats.</param>
        /// <param name="seat">The seat.</param>
        /// <returns></returns>
        private static int FindNextAvailableSeat(List<int> usedSeats, int seat)
        {
            if (!usedSeats.Contains(seat))
                return seat;

            int diff = 1;
            while (true)
            {
                if (seat - diff > 0 && !usedSeats.Contains(seat - diff))
                    return seat - diff;
                if (!usedSeats.Contains(seat + diff))
                    return seat + diff;
                diff++;
            }
        }
    }
}