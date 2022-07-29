using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearchCodeExamples.TestTaker
{
    public static class RansomNote
    {
        /// <summary>
        /// Determines whether this instance can construct the specified ransom note.
        /// </summary>
        /// <param name="ransomNote">The ransom note.</param>
        /// <param name="magazine">The magazine.</param>
        /// <returns>
        ///   <c>true</c> if this instance can construct the specified ransom note; otherwise, <c>false</c>.
        /// </returns>
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length) return false;

            var source = magazine;
            for (var i = 0; i < ransomNote.Length; i++)
            {
                if (source.Contains(ransomNote[i]))
                {
                    source = source.Remove(source.IndexOf(ransomNote[i]), 1);
                }
                else
                    return false;
            }
            return true;
        }
    }
}
