#include "KWeakestRowsInAMatrix.h"

/// <summary>
/// ks the weakest rows.
/// </summary>
/// <param name="mat">The mat.</param>
/// <param name="k">The k.</param>
/// <returns></returns>
array<int>^ KWeakestRowsInAMatrix::KWeakestRows(array<array<int>^>^ mat, int k)
{
	Dictionary<int, int>^ indicies = gcnew Dictionary<int, int>();
	for (int i = 0; i < mat->Length; i++)
	{
		int solders = 0;
		for (int j = 0; j < mat[i]->Length; j++)
			if (mat[i][j] == 1) solders++;
		indicies->Add(i, solders);
	}
	array<KeyValuePair<int, int>>^ result = Enumerable::ToArray(indicies);
	Array::Sort(result, gcnew Comparison<KeyValuePair<int, int>>(Compare));

	array<int>^ ret = gcnew array<int>(k);
	for (int i = 0; i < k; i++)
		ret[i] = result[i].Key;
	return ret;
}

/// <summary>
/// Compares the specified i1.
/// </summary>
/// <param name="i1">The i1.</param>
/// <param name="i2">The i2.</param>
/// <returns></returns>
int KWeakestRowsInAMatrix::Compare(KeyValuePair<int, int> i1, KeyValuePair<int, int> i2)
{
	int result = i1.Value.CompareTo(i2.Value);

	if (result == 0)
		result = i1.Key.CompareTo(i2.Key);

	return result;
}
