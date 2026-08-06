namespace JobSearchCodeExamples.cs.Contest.LeetCodeContest313;

/// <summary>
/// This class contains a method to minimize the XOR of two integers.
/// </summary>
public static class Question3
{
    /// <summary>
    /// Minimizes the XOR of two integers.
    /// </summary>
    /// <param name="num1">The first integer.</param>
    /// <param name="num2">The second integer.</param>
    /// <returns>The minimized XOR value.</returns>
    /// <remarks>
    /// 2429. Minimize XOR
    /// 
    /// Given two positive integers num1 and num2, find the positive integer x such that:
    /// 
    ///  * x has the same number of set bits as num2, and
    ///  * The value x XOR num1 is minimal.
    /// 
    /// Note that XOR is the bitwise XOR operation.
    /// 
    /// Return the integer x. The test cases are generated such that x is uniquely determined.
    /// 
    /// The number of set bits of an integer is the number of 1's in its binary representation.
    /// </remarks>
    public static int MinimizeXor(int num1, int num2)
    {
        int num1Bits = 0;
        int num2Bits = 0;
        int bitPos = 0;

        // get a count of the bits in num1 and num2
        for (int i = 0; i < 32; i++)
        {
            if ((num1 & (1 << i)) != 0) num1Bits++;
            if ((num2 & (1 << i)) != 0) num2Bits++;
        }

        // if the bits are the same, return num1
        if (num1Bits == num2Bits) { return num1; }

        // if num1 has fewer bits than num2, add bits to num1
        if (num1Bits < num2Bits)
        {
            int bitsToAdd = num2Bits - num1Bits;
            while (bitsToAdd > 0)
            {
                while (((num1 >> bitPos) & 1) == 1) bitPos++;
                num1 |= (1 << bitPos);
                bitsToAdd--;
            }
            return num1;
        }

        // if num1 has more bits than num2, remove bits from num1
        int bitsToRemove = num1Bits - num2Bits;
        while (bitsToRemove > 0)
        {
            num1 &= (num1 - 1);
            bitsToRemove--;
        }

        return num1;
    }
}
