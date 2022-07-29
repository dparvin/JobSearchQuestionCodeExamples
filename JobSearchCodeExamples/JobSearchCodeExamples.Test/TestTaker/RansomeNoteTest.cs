using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchCodeExamples.Test.TestTaker
{
    public class RansomeNoteTest
    {
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
}
