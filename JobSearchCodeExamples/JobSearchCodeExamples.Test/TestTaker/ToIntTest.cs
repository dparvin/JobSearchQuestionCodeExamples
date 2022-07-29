using JobSearchCodeExamples.TestTaker;

namespace JobSearchCodeExamples.Test.TestTaker;

public class ToIntTest
{
    /// <summary>
    /// Romans to int test.
    /// </summary>
    [Theory]
    [MemberData(nameof(TestData))]
    public void RomanToInt1Test(string romanNumber, int expectedResults)
    {
        Assert.Equal(expectedResults, ToInt.RomanToInt(romanNumber));
    }

    /// <summary>
    /// Romans to int test.
    /// </summary>
    [Theory]
    [MemberData(nameof(TestData))]
    public void RomanToInt2Test(string romanNumber, int expectedResults)
    {
        Assert.Equal(expectedResults, ToInt.RomanToInt2(romanNumber));
    }

    /// <summary>
    /// Romans to int test.
    /// </summary>
    [Theory]
    [MemberData(nameof(TestData))]
    public void RomanToInt3Test(string romanNumber, int expectedResults)
    {
        Assert.Equal(expectedResults, ToInt.RomanToInt3(romanNumber));
    }

    /// <summary>
    /// Gets the test data.
    /// </summary>
    /// <value>
    /// The test data.
    /// </value>
    public static IEnumerable<object[]> TestData
    {
        get
        {
            var result = new List<object[]>
            {
                new object[] { "I", 1 },
                new object[] { "II", 2 },
                new object[] { "III", 3 },
                new object[] { "IV", 4 },
                new object[] { "V", 5 },
                new object[] { "VI", 6 },
                new object[] { "VII", 7 },
                new object[] { "VIII", 8 },
                new object[] { "IX", 9 },
                new object[] { "X", 10 },
                new object[] { "XI", 11 },
                new object[] { "XX", 20 },
                new object[] { "XXI", 21 },
                new object[] { "XXII", 22 },
                new object[] { "XXIII", 23 },
                new object[] { "XXIV", 24 },
                new object[] { "XXV", 25 },
                new object[] { "XLV", 45 },
                new object[] { "LVIII", 58 },
                new object[] { "DCCC", 800 },
                new object[] { "MCMLXIII", 1963 },
                new object[] { "MCMXCIV", 1994 },
                new object[] { "MMC", 2100 },
                new object[] { "MMCD", 2400 },
                new object[] { "MMCM", 2900 },
                new object[] { "MMM", 3000 },
                new object[] { "MMMCMLXIV", 3964 },
                new object[] { "MMMCMLXV", 3965 },
                new object[] { "MMMCMLXVI", 3966 },
                new object[] { "MMMCMLXVII", 3967 },
                new object[] { "MMMCMLXVIII", 3968 },
                new object[] { "MMMCMLXIX", 3969 },
                new object[] { "MMMCMLXX", 3970 },
                new object[] { "MMMCMLXXI", 3971 },
                new object[] { "MMMCMLXXII", 3972 },
                new object[] { "MMMCMLXXIII", 3973 },
                new object[] { "MMMCMLXXIV", 3974 },
                new object[] { "MMMCMLXXV", 3975 },
                new object[] { "MMMCMLXXVI", 3976 },
                new object[] { "MMMCMLXXVII", 3977 },
                new object[] { "MMMCMLXXVIII", 3978 },
                new object[] { "MMMCMLXXIX", 3979 },
                new object[] { "MMMCMLXXX", 3980 },
                new object[] { "MMMCMLXXXI", 3981 },
                new object[] { "MMMCMLXXXII", 3982 },
                new object[] { "MMMCMLXXXIII", 3983 },
                new object[] { "MMMCMLXXXIV", 3984 },
                new object[] { "MMMCMLXXXV", 3985 },
                new object[] { "MMMCMLXXXVI", 3986 },
                new object[] { "MMMCMLXXXVII", 3987 },
                new object[] { "MMMCMLXXXVIII", 3988 },
                new object[] { "MMMCMLXXXIX", 3989 },
                new object[] { "MMMCMXC", 3990 },
                new object[] { "MMMCMXCI", 3991 },
                new object[] { "MMMCMXCII", 3992 },
                new object[] { "MMMCMXCIII", 3993 },
                new object[] { "MMMCMXCIV", 3994 },
                new object[] { "MMMCMXCV", 3995 },
                new object[] { "MMMCMXCVI", 3996 },
                new object[] { "MMMCMXCVII", 3997 },
                new object[] { "MMMCMXCVIII", 3998 },
                new object[] { "MMMCMXCIX", 3999 }
            };

            return result;
        }
    }
}
