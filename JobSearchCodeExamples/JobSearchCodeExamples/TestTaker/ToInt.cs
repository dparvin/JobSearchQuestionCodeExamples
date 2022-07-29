namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// Roman Numerals to an integer
/// </summary>
public static class ToInt
{
    /// <summary>
    /// Romans to int.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <returns></returns>
    public static int RomanToInt(string s)
    {
        int pos = 0;
        int result = 0;
        while (pos < s.Length)
        {
            string spos = s[pos].ToString();
            string snext = string.Empty;
            if (pos < s.Length - 1)
                snext = s[pos + 1].ToString();
            switch (spos)
            {
                case "I":
                    if (snext == "V")
                    {
                        result += 4;
                        pos++;
                    }
                    else if (snext == "X")
                    {
                        result += 9;
                        pos++;
                    }
                    else
                        result += 1;
                    break;
                case "V":
                    result += 5;
                    break;
                case "X":
                    if (snext == "L")
                    {
                        result += 40;
                        pos++;
                    }
                    else if (snext == "C")
                    {
                        result += 90;
                        pos++;
                    }
                    else
                        result += 10;
                    break;
                case "L":
                    result += 50;
                    break;
                case "C":
                    if (snext == "D")
                    {
                        result += 400;
                        pos++;
                    }
                    else if (snext == "M")
                    {
                        result += 900;
                        pos++;
                    }
                    else
                        result += 100;
                    break;
                case "D":
                    result += 500;
                    break;
                case "M":
                    result += 1000;
                    break;

            }
            pos++;
        }
        return result;
    }

    /// <summary>
    /// Romans to int.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <returns></returns>
    public static int RomanToInt2(string s)
    {
        string[] roman = { "I", "V", "X", "L", "C", "D", "M" };
        int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
        string[] before = { "I", "X", "C" };
        string[][] after = { new string[] { "V", "X" }, new string[] { "L", "C" }, new string[] { "D", "M" } };
        int[][] extraValues = { new int[] { 4, 9 }, new int[] { 40, 90 }, new int[] { 400, 900 } };
        int pos = 0;
        int result = 0;
        while (pos < s.Length)
        {
            string spos = s[pos].ToString();
            string snext = string.Empty;
            if (pos < s.Length - 1)
                snext = s[pos + 1].ToString();
            int romanIndex = Array.IndexOf(roman, spos);
            if (before.Contains(spos) && !string.IsNullOrEmpty(snext))
            {
                int beforeIndex = Array.IndexOf(before, spos);
                if (after[beforeIndex].Contains(snext))
                {
                    result += extraValues[beforeIndex][Array.IndexOf(after[beforeIndex], snext)];
                    pos++;
                }
                else
                    result += values[romanIndex];
            }
            else
                result += values[romanIndex];
            pos++;
        }
        return result;
    }

    /// <summary>
    /// Romans to int.
    /// </summary>
    /// <param name="s">The s.</param>
    /// <returns></returns>
    public static int RomanToInt3(string s)
    {
        Dictionary<string, int> RomanValues = new();
        RomanValues.Add("I", 1);
        RomanValues.Add("V", 5);
        RomanValues.Add("X", 10);
        RomanValues.Add("L", 50);
        RomanValues.Add("C", 100);
        RomanValues.Add("D", 500);
        RomanValues.Add("M", 1000);
        int pos = 0;
        int result = 0;
        while (pos < s.Length)
        {
            string spos = s[pos].ToString();
            string snext = string.Empty;
            if (pos < s.Length - 1)
                snext = s[pos + 1].ToString();
            if (string.IsNullOrEmpty(snext))
                result += RomanValues[spos];
            else if (RomanValues[spos] < RomanValues[snext])
                result -= RomanValues[spos];
            else
                result += RomanValues[spos];
            pos++;
        }
        return result;
    }
}
