Imports JobSearchCodeExamples.VB.TestTaker
Imports Xunit

Namespace TestTaker

    Public Class ToIntTest

        ''' <summary>
        ''' Romans to int test.
        ''' </summary>
        <Theory>
        <MemberData(NameOf(ToIntTest.TestData))>
        Public Sub RomanToInt1Test(
                ByVal romanNumber As String,
                ByVal expectedResults As Integer)

            Assert.Equal(expectedResults, ToInt.RomanToInt(romanNumber))

        End Sub

        ''' <summary>
        ''' Romans to int test.
        ''' </summary>
        <Theory>
        <MemberData(NameOf(ToIntTest.TestData))>
        Public Sub RomanToInt2Test(
                ByVal romanNumber As String,
                ByVal expectedResults As Integer)

            Assert.Equal(expectedResults, ToInt.RomanToInt2(romanNumber))

        End Sub

        ''' <summary>
        ''' Romans to int test.
        ''' </summary>
        <Theory>
        <MemberData(NameOf(ToIntTest.TestData))>
        Public Sub RomanToInt3Test(
                ByVal romanNumber As String,
                ByVal expectedResults As Integer)

            Assert.Equal(expectedResults, ToInt.RomanToInt3(romanNumber))

        End Sub

        ''' <summary>
        ''' Gets the test data.
        ''' </summary>
        ''' <value>
        ''' The test data.
        ''' </value>
        Public Shared ReadOnly Property TestData As IEnumerable(Of Object())

            Get

                Dim result = New List(Of Object()) From {
                    New Object() {"I", 1},
                    New Object() {"II", 2},
                    New Object() {"III", 3},
                    New Object() {"IV", 4},
                    New Object() {"V", 5},
                    New Object() {"VI", 6},
                    New Object() {"VII", 7},
                    New Object() {"VIII", 8},
                    New Object() {"IX", 9},
                    New Object() {"X", 10},
                    New Object() {"XI", 11},
                    New Object() {"XX", 20},
                    New Object() {"XXI", 21},
                    New Object() {"XXII", 22},
                    New Object() {"XXIII", 23},
                    New Object() {"XXIV", 24},
                    New Object() {"XXV", 25},
                    New Object() {"XLV", 45},
                    New Object() {"LVIII", 58},
                    New Object() {"DCCC", 800},
                    New Object() {"MCMLXIII", 1963},
                    New Object() {"MCMXCIV", 1994},
                    New Object() {"MMC", 2100},
                    New Object() {"MMCD", 2400},
                    New Object() {"MMCM", 2900},
                    New Object() {"MMM", 3000},
                    New Object() {"MMMCMLXIV", 3964},
                    New Object() {"MMMCMLXV", 3965},
                    New Object() {"MMMCMLXVI", 3966},
                    New Object() {"MMMCMLXVII", 3967},
                    New Object() {"MMMCMLXVIII", 3968},
                    New Object() {"MMMCMLXIX", 3969},
                    New Object() {"MMMCMLXX", 3970},
                    New Object() {"MMMCMLXXI", 3971},
                    New Object() {"MMMCMLXXII", 3972},
                    New Object() {"MMMCMLXXIII", 3973},
                    New Object() {"MMMCMLXXIV", 3974},
                    New Object() {"MMMCMLXXV", 3975},
                    New Object() {"MMMCMLXXVI", 3976},
                    New Object() {"MMMCMLXXVII", 3977},
                    New Object() {"MMMCMLXXVIII", 3978},
                    New Object() {"MMMCMLXXIX", 3979},
                    New Object() {"MMMCMLXXX", 3980},
                    New Object() {"MMMCMLXXXI", 3981},
                    New Object() {"MMMCMLXXXII", 3982},
                    New Object() {"MMMCMLXXXIII", 3983},
                    New Object() {"MMMCMLXXXIV", 3984},
                    New Object() {"MMMCMLXXXV", 3985},
                    New Object() {"MMMCMLXXXVI", 3986},
                    New Object() {"MMMCMLXXXVII", 3987},
                    New Object() {"MMMCMLXXXVIII", 3988},
                    New Object() {"MMMCMLXXXIX", 3989},
                    New Object() {"MMMCMXC", 3990},
                    New Object() {"MMMCMXCI", 3991},
                    New Object() {"MMMCMXCII", 3992},
                    New Object() {"MMMCMXCIII", 3993},
                    New Object() {"MMMCMXCIV", 3994},
                    New Object() {"MMMCMXCV", 3995},
                    New Object() {"MMMCMXCVI", 3996},
                    New Object() {"MMMCMXCVII", 3997},
                    New Object() {"MMMCMXCVIII", 3998},
                    New Object() {"MMMCMXCIX", 3999}
                    }

                Return result
            End Get

        End Property

    End Class

End Namespace
