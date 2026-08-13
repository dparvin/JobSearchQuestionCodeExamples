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
            int[] results = new int[seatsRequested.Length];
            List<int> usedSeats = [.. seatsAssign];
            for (int i = 0; i < seatsRequested.Length; i++)
            {
                int nextAvailableSeat = FindNextAvailableSeat(usedSeats, seatsRequested[i]);
                results[i] = nextAvailableSeat;
                usedSeats.Add(nextAvailableSeat);
            }

            seatsAssign = [.. usedSeats];
            return results;
        }

        /// <summary>
        /// Finds the next available seat.
        /// </summary>
        /// <param name="usedSeats">The used seats.</param>
        /// <param name="seat">The seat.</param>
        /// <returns></returns>
        private static int FindNextAvailableSeat(List<int> usedSeats, int seat)
        {
            if (!usedSeats.Contains(seat)) return seat;

            int diff = 1;
            while (true)
            {
                int lowerSeat = seat - diff;
                int upperSeat = seat + diff;
                if (lowerSeat > 0 && !usedSeats.Contains(lowerSeat)) return lowerSeat;
                if (!usedSeats.Contains(upperSeat)) return upperSeat;
                diff++;
            }
        }

        /// <summary>
        /// Assigns the seats2.
        /// </summary>
        /// <param name="seatsAssign">The seats assign.</param>
        /// <param name="seatsRequested">The seats requested.</param>
        /// <returns></returns>
        public static int[] AssignSeats2(ref int[] seatsAssign, int[] seatsRequested)
        {
            List<int> results = [];
            List<int> usedSeats = [.. seatsAssign];
            foreach (int seat in seatsRequested)
            {
                int nextAvailableSeat = FindNextAvailableSeat2(usedSeats, seat);
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
        private static int FindNextAvailableSeat2(List<int> usedSeats, int seat)
        {
            if (!usedSeats.Contains(seat))
                return seat;

            int FindSeat(int diff)
            {
                int lowerSeat = seat - diff;
                int higherSeat = seat + diff;

                if (lowerSeat > 0 && !usedSeats.Contains(lowerSeat))
                    return lowerSeat;

                if (!usedSeats.Contains(higherSeat))
                    return higherSeat;

                return FindSeat(diff + 1);
            }

            return FindSeat(1);
        }
    }
}