namespace JobSearchCodeExamples.cpp.Test.TestTaker
{
    public class CustomCodeTest
    {
        /// <summary>
        /// Tests the version compare.
        /// </summary>
        /// <param name="version1">The version1.</param>
        /// <param name="version2">The version2.</param>
        /// <param name="ExpectedResult">The expected result.</param>
        [Theory]
        [InlineData("2", "2.0", 0)]
        [InlineData("2", "2.0.0", 0)]
        [InlineData("2", "2.0.0.0", 0)]
        [InlineData("2", "2.0.0.0.0", 0)]
        [InlineData("2", "2.0.0.0.1", -1)]
        [InlineData("2", "2.1", -1)]
        [InlineData("2.1.0", "2.0.1", 1)]
        [InlineData("2.10.0.1", "2.1.0.10", 1)]
        [InlineData("2.0.1", "1.2000.1", 1)]
        public void TestVersionCompare(string version1, string version2, int ExpectedResult)
        {
            var result = CustomCode.VersionCompare(version1, version2);
            Assert.Equal(ExpectedResult, result);
        }

        /// <summary>
        /// Tests the version compare.
        /// </summary>
        /// <param name="version1">The version1.</param>
        /// <param name="version2">The version2.</param>
        /// <param name="ExpectedResult">The expected result.</param>
        [Theory]
        [InlineData("2", "2.0", 0)]
        [InlineData("2", "2.0.0", 0)]
        [InlineData("2", "2.0.0.0", 0)]
        [InlineData("2", "2.0.0.0.0", 0)]
        [InlineData("2", "2.0.0.0.1", -1)]
        [InlineData("2", "2.1", -1)]
        [InlineData("2.1.0", "2.0.1", 1)]
        [InlineData("2.10.0.1", "2.1.0.10", 1)]
        [InlineData("2.0.1", "1.2000.1", 1)]
        public void TestLongVersionCompare(string version1, string version2, int ExpectedResult)
        {
            var result = CustomCode.LongVersionCompare(version1, version2);
            Assert.Equal(ExpectedResult, result);
        }

        /// <summary>
        /// Finds the missing number.
        /// </summary>
        /// <remarks>
        /// Question: How do you find the missing number in an array of 1-100?
        /// This routine will mathematically figure out which number is missing.  The Arrange
        /// part creates an array of integers with one item missing.  The Act part gets a total
        /// of all of the items in the array and calculates what the total should be if all of
        /// the items were in the array ( formula: n(n+1)/2 ).  Subtracting the two numbers 
        /// gives you the value that is missing from the array.
        /// 
        /// This test actually randomly removes the item that is missing, so the item missing 
        /// is different every time the routine is run.
        /// </remarks>
        [Fact]
        public void FindMissingNumber()
        {
            // Arrange
            int expectedMax = 100;
            int[] a = new int[expectedMax - 1];
            int missing = new Random().Next(expectedMax) + 1;
            int i = 1;
            for (var j = 0; j < a.Length; j++)
            {
                if (i == missing) i++;
                a[j] = i;
                i++;
            }

            // Act
            int FoundMissing = CustomCode.FindMissingEntry(a);

            // Assert
            Assert.Equal(missing, FoundMissing);
        }
    }
}
