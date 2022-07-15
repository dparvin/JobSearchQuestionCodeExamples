#include "LinkedLists.h"

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
