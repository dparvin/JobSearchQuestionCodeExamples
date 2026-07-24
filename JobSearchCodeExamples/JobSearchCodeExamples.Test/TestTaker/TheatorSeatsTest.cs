using JobSearchCodeExamples.cs.TestTaker;

namespace JobSearchCodeExamples.cs.Test.TestTaker
{
    /// <summary>
    /// TheatorSeatsTest class contains unit tests for the TheaterSeats class.
    /// </summary>
    public class TheatorSeatsTest
    {
        /// <summary>
        /// Assigns the seats test.
        /// </summary>
        [Fact]
        public void AssignSeatsTest()
        {
            int[] seatsAssign = new int[] { 1, 3, 5 };
            int[] seatsRequested = new int[] { 2, 3, 4 };
            int[] expectedResult = new int[] { 2, 6, 4 };
            int[] result = TheaterSeats.AssignSeats(ref seatsAssign, seatsRequested);
            Assert.Equal(expectedResult, result);
        }
    }
}