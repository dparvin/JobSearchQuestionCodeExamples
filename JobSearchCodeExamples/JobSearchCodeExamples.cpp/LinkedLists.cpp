#include "LinkedLists.h"

/// <summary>
/// Reverses the list.
/// </summary>
/// <param name="list">The list.</param>
/// <returns></returns>
generic<typename T>
LinkedList<T>^ LinkedLists::ReverseList(LinkedList<T>^ list)
{
	LinkedList<T>^ results = gcnew LinkedList<T>();
	if (list == nullptr || list->Count == 0) return list;
	LinkedListNode<T>^ currentItem = list->First;
	while (currentItem != nullptr)
	{
		results->AddFirst(currentItem->Value);
		currentItem = currentItem->Next;
	}

	return results;
}
