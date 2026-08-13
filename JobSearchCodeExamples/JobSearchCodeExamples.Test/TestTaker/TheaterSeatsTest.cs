using JobSearchCodeExamples.cs.TestTaker;

namespace JobSearchCodeExamples.cs.Test.TestTaker
{
    /// <summary>
    /// TheaterSeatsTest class contains unit tests for the TheaterSeats class.
    /// </summary>
    public class TheaterSeatsTest
    {
        /// <summary>
        /// Assigns the seats test.
        /// </summary>
        /// <remarks>
        /// Tests the AssignSeats method of the TheaterSeats class. The test verifies
        /// that requested seats are assigned when available and that, when a requested
        /// seat is already assigned, the closest available seat is selected. When two
        /// available seats are equally close to the requested seat, the lower-numbered
        /// seat is selected.
        /// 
        /// This question came from an interview question for a software engineering
        /// position.
        /// </remarks>
        [Fact]
        public void AssignSeatsTest()
        {
            var seatsAssign = new int[] { 1, 3, 5 };
            var seatsRequested = new int[] { 2, 3, 4 };
            var expectedResult = new int[] { 2, 4, 6 };
            var result = TheaterSeats.AssignSeats(ref seatsAssign, seatsRequested);
            Assert.Equal(expectedResult, result);
        }

        /// <summary>
        /// Assigns the seats test.
        /// </summary>
        /// <remarks>
        /// Tests the AssignSeats method of the TheaterSeats class. The test verifies
        /// that requested seats are assigned when available and that, when a requested
        /// seat is already assigned, the closest available seat is selected. When two
        /// available seats are equally close to the requested seat, the lower-numbered
        /// seat is selected.
        /// 
        /// This question came from an interview question for a software engineering
        /// position.
        /// </remarks>
        [Fact]
        public void AssignSeats2Test()
        {
            var seatsAssign = new int[] { 1, 3, 5 };
            var seatsRequested = new int[] { 2, 3, 4 };
            var expectedResult = new int[] { 2, 4, 6 };
            var result = TheaterSeats.AssignSeats2(ref seatsAssign, seatsRequested);
            Assert.Equal(expectedResult, result);
        }
    }
}