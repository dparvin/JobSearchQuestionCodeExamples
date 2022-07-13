Imports System.Globalization

Namespace JobSeearchCodeExamples.VB.TestTaker

    ''' <summary>
    ''' A class that supports version numbers that are longer than the normal
    ''' version object.
    ''' </summary>
    ''' <seealso cref="IComparable" />
    Friend Class LongVersion

        Implements IComparable

        ''' <summary>
        ''' Initializes a new instance of the <see cref="LongVersion"/> class.
        ''' </summary>
        ''' <param name="version">The version.</param>
        Public Sub New(version As String)

            Dim _parts As String() = version.Split(".")
            ReDim Parts(_parts.Length - 1)
            Dim i As Integer = 0
            For Each part In _parts
                Parts(i) = Integer.Parse(part, CultureInfo.InvariantCulture)
                i += 1
            Next

        End Sub

        ''' <summary>
        ''' Gets the parts.
        ''' </summary>
        ''' <value>
        ''' The parts.
        ''' </value>
        Public ReadOnly Property Parts As Integer()

        ''' <summary>
        ''' Determines whether the specified <see cref="Object" />, is equal to this instance.
        ''' </summary>
        ''' <param name="obj">The <see cref="Object" /> to compare with this instance.</param>
        ''' <returns>
        '''   <c>true</c> if the specified <see cref="Object" /> is equal to this instance; otherwise, <c>false</c>.
        ''' </returns>
        Public Overrides Function Equals(obj As Object) As Boolean

            If ReferenceEquals(Me, obj) Then Return True
            If obj Is Nothing Then Return False

            Return CompareTo(obj) = 0

        End Function

        ''' <summary>
        ''' Returns a hash code for this instance.
        ''' </summary>
        ''' <returns>
        ''' A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        ''' </returns>
        Public Overrides Function GetHashCode() As Integer

            Dim hash As Integer = 0
            For i As Integer = 0 To Parts.Length - 1
                hash = hash * 17 + Parts(i).GetHashCode()
            Next
            Return hash

        End Function

        ''' <summary>
        ''' Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        ''' </summary>
        ''' <param name="obj">An object to compare with this instance.</param>
        ''' <returns>
        ''' A value that indicates the relative order of the objects being compared. The return value has these meanings:
        ''' <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description> This instance precedes <paramref name="obj" /> in the sort order.</description></item><item><term> Zero</term><description> This instance occurs in the same position in the sort order as <paramref name="obj" />.</description></item><item><term> Greater than zero</term><description> This instance follows <paramref name="obj" /> in the sort order.</description></item></list>
        ''' </returns>
        Public Function CompareTo(
            obj As Object) As Integer Implements IComparable.CompareTo

            If ReferenceEquals(Me, obj) Then Return 0
            If obj Is Nothing Then Return 0
            Dim other As LongVersion = obj
            Dim longest As Integer = If(Parts.Length < other.Parts.Length, other.Parts.Length, Parts.Length)
            For i As Integer = 0 To longest
                Dim item1 As Integer = 0
                Dim item2 As Integer = 0
                If i < Parts.Length Then item1 = Parts(i)
                If i < other.Parts.Length Then item2 = other.Parts(i)
                Dim results As Integer = If(item1 < item2, -1, If(item1 > item2, 1, 0))
                If results <> 0 Then Return results
            Next

            Return 0

        End Function

        ''' <summary>
        ''' Implements the operator =.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator =(
                left As LongVersion,
                right As LongVersion) As Boolean

            If left Is Nothing Then Return right Is Nothing
            Return left.Equals(right)

        End Operator

        ''' <summary>
        ''' Implements the operator &lt;&gt;.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator <>(
                left As LongVersion,
                right As LongVersion) As Boolean

            Return Not left = right

        End Operator

        ''' <summary>
        ''' Implements the operator &lt;.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator <(
                left As LongVersion,
                right As LongVersion) As Boolean

            Return If(left Is Nothing, right IsNot Nothing, left.CompareTo(right) < 0)

        End Operator

        ''' <summary>
        ''' Implements the operator &lt;=.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator <=(
                left As LongVersion,
                right As LongVersion) As Boolean

            Return left Is Nothing OrElse left.CompareTo(right) <= 0

        End Operator

        ''' <summary>
        ''' Implements the operator &gt;.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator >(
                left As LongVersion,
                right As LongVersion) As Boolean

            Return left IsNot Nothing AndAlso left.CompareTo(right) > 0

        End Operator

        ''' <summary>
        ''' Implements the operator &gt;=.
        ''' </summary>
        ''' <param name="left">The left.</param>
        ''' <param name="right">The right.</param>
        ''' <returns>
        ''' The result of the operator.
        ''' </returns>
        Public Shared Operator >=(
                left As LongVersion,
                right As LongVersion) As Boolean

            Return If(left Is Nothing, right Is Nothing, left.CompareTo(right) >= 0)

        End Operator

        ''' <summary>
        ''' Converts to string.
        ''' </summary>
        ''' <returns>
        ''' A <see cref="String" /> that represents this instance.
        ''' </returns>
        Public Overrides Function ToString() As String

            Dim result As String = String.Empty
            For Each item As Integer In Parts
                result &= "." + item.ToString()
            Next

            Return Right(result, result.Length - 1)

        End Function

    End Class

End Namespace
