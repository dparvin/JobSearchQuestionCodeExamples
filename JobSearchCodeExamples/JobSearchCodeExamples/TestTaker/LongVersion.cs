namespace JobSearchCodeExamples.TestTaker;

/// <summary>
/// A class that supports version numbers that are longer than the normal 
/// version object.
/// </summary>
/// <seealso cref="IComparable" />
public class LongVersion : IComparable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LongVersion"/> class.
    /// </summary>
    /// <param name="version">The version.</param>
    public LongVersion(string version)
    {
        string[] parts = version.Split('.');
        Parts = new int[parts.Length];
        int i = 0;
        foreach (string part in parts)
            Parts[i++] = int.Parse(part, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Gets or sets the parts.
    /// </summary>
    /// <value>
    /// The parts.
    /// </value>
    public int[] Parts { get; private set; }

    /// <summary>
    /// Determines whether the specified <see cref="object" />, is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj is null) return false;

        return CompareTo(obj) == 0;
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
    /// </returns>
    public override int GetHashCode()
    {
        int hash = 0;
        for (int i = 0; i < Parts.Length; i++)
        {
            hash = hash * 17 + Parts[i].GetHashCode();
        }
        return hash;
    }

    /// <summary>
    /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns>
    /// A value that indicates the relative order of the objects being compared. The return value has these meanings:
    /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item></list>
    /// </returns>
    public int CompareTo(object? obj)
    {
        if (ReferenceEquals(this, obj)) return 0;
        if (obj is null) return 0;
        LongVersion? other = obj as LongVersion;
        int? longest = Parts.Length < other?.Parts.Length ? other?.Parts.Length : Parts.Length;
        for (int i = 0; i < longest; i++)
        {
            int item1 = 0;
            int item2 = 0;
            if (i < Parts.Length) item1 = Parts[i];
            if (i < other?.Parts.Length) item2 = other.Parts[i];
            int result = item1 < item2 ? -1 : item1 > item2 ? 1 : 0;
            if (result != 0) return result;
        }
        return 0;
    }

    /// <summary>
    /// Implements the operator ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator ==(LongVersion left, LongVersion right)
    {
        if (left is null) return right is null;

        return left.Equals(right);
    }

    /// <summary>
    /// Implements the operator !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator !=(LongVersion left, LongVersion right)
    {
        return !(left == right);
    }

    /// <summary>
    /// Implements the operator &lt;.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator <(LongVersion left, LongVersion right)
    {
        return left is null ? right is not null : left.CompareTo(right) < 0;
    }

    /// <summary>
    /// Implements the operator &lt;=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator <=(LongVersion left, LongVersion right)
    {
        return left is null || left.CompareTo(right) <= 0;
    }

    /// <summary>
    /// Implements the operator &gt;.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator >(LongVersion left, LongVersion right)
    {
        return left is not null && left.CompareTo(right) > 0;
    }

    /// <summary>
    /// Implements the operator &gt;=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>
    /// The result of the operator.
    /// </returns>
    public static bool operator >=(LongVersion left, LongVersion right)
    {
        return left is null ? right is null : left.CompareTo(right) >= 0;
    }

    /// <summary>
    /// Converts to string.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    public override string ToString()
    {
        var result = string.Empty;
        foreach (var item in Parts)
        {
            result += "." + item.ToString();
        }
        return result[1..];
    }
}
