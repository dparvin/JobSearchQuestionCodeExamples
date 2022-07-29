namespace JobSearchCodeExamples.Test.TestTaker;

public class WeakestRowsTest
{
    [Fact]
    public void KWeakestRowsInAMatrixTest()
    {
        int[][] testArray =
        {
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,0},
            new int[] {1,0,0,0,0},
            new int[] {1,1,0,0,0},
            new int[] {1,1,1,1,1}
        };
        int[] expectedResult = { 2, 0, 3 };
        int[] result = KWeakestRowsInAMatrix.KWeakestRows(testArray, 3);
        Assert.Equal(3, result.Length);
        Assert.Equal(expectedResult, result);
    }
}
