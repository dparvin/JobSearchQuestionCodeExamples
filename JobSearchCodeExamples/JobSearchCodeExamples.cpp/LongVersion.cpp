#include "LongVersion.h"

/// <summary>
/// Initializes a new instance of the <see cref="LongVersion"/> class.
/// </summary>
/// <param name="version">The version.</param>
LongVersion::LongVersion(String^ version)
{
	array<String^>^ parts = version->Split('.');
	Parts = gcnew array<int>(parts->Length);
	int i = 0;
	for each (String ^ part in parts)
		Parts[i++] = Int32::Parse(part, CultureInfo::InvariantCulture);
}

/// <summary>
/// Equals the specified object.
/// </summary>
/// <param name="obj">The object.</param>
/// <returns></returns>
bool LongVersion::Equals(Object^ obj)
{
	if (Object::ReferenceEquals(this, obj)) return true;
	if (obj == nullptr) return false;

	return CompareTo(obj) == 0;
}

/// <summary>
/// Gets the hash code.
/// </summary>
/// <returns></returns>
int LongVersion::GetHashCode()
{
	int hash = 0;
	for (int i = 0; i < Parts->Length; i++)
		hash = hash * 17 + Parts[i].GetHashCode();

	return hash;
}

/// <summary>
/// Converts to string.
/// </summary>
/// <returns></returns>
String^ LongVersion::ToString()
{
	String^ result = String::Empty;
	for each (int item in Parts)
		result += "." + item.ToString();
	return result;
}

/// <summary>
/// Compares to.
/// </summary>
/// <param name="obj">The object.</param>
/// <returns></returns>
int LongVersion::CompareTo(System::Object^ obj)
{
	if (ReferenceEquals(this, obj)) return 0;
	if (obj == nullptr) return 0;
	LongVersion^ other = (LongVersion^)obj;
	int longest = Parts->Length < other->Parts->Length ? other->Parts->Length : Parts->Length;
	for (int i = 0; i < longest; i++)
	{
		int item1 = 0;
		int item2 = 0;
		if (i < Parts->Length) item1 = Parts[i];
		if (i < other->Parts->Length) item2 = other->Parts[i];
		int result = item1 < item2 ? -1 : item1 > item2 ? 1 : 0;
		if (result != 0) return result;
	}
	return 0;
}

/// <summary>
/// Override for Operator ==.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator==(LongVersion^ left, LongVersion^ right)
{
	if (left == nullptr) return right == nullptr;
	return left->Equals(right);
}

/// <summary>
/// Override for Operator !=.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator!=(LongVersion^ left, LongVersion^ right)
{
	return !(left == right);
}

/// <summary>
/// Override for Operator <.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator<(LongVersion^ left, LongVersion^ right)
{
	return left == nullptr ? right != nullptr : left->CompareTo(right) < 0;
}

/// <summary>
/// Override for Operator <=.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator<=(LongVersion^ left, LongVersion^ right)
{
	return left == nullptr || left->CompareTo(right) <= 0;
}

/// <summary>
/// Override for Operator >.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator>(LongVersion^ left, LongVersion^ right)
{
	return left != nullptr ? right == nullptr : left->CompareTo(right) >= 0;
}

/// <summary>
/// Override for Operator >=.
/// </summary>
/// <param name="left">The left.</param>
/// <param name="right">The right.</param>
/// <returns></returns>
bool LongVersion::operator>=(LongVersion^ left, LongVersion^ right)
{
	return left == nullptr ? right == nullptr : left->CompareTo(right) >= 0;
}
