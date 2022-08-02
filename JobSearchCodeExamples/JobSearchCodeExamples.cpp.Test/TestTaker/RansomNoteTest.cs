namespace JobSearchCodeExamples.cpp.Test.TestTaker;

public class RansomNoteTest
{
    /// <summary>
    /// Determines whether this instance test of CanConstruct the specified ransom note.
    /// </summary>
    /// <param name="ransomNote">The ransom note.</param>
    /// <param name="magazine">The magazine.</param>
    /// <param name="expectedResult">if set to the expected result.</param>
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa", "aab", true)]
    [InlineData("aa", "b", false)]
    [InlineData("aabc", "aabd", false)]
    public void CanConstructTest(string ransomNote, string magazine, bool expectedResult)
    {
        Assert.Equal(expectedResult, RansomNote.CanConstruct(ransomNote, magazine));
    }
}
