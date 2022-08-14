#include "LeetCode.h"

IList<String^>^ LeetCode::FizzBuzz(int n)
{
	IList<String^>^ result = gcnew List<String^>();
	for (int i = 1; i <= n; i++)
	{
		if (i % 3 == 0 && i % 5 == 0)
			result->Add("FizzBuzz");
		else if (i % 3 == 0)
			result->Add("Fizz");
		else if (i % 5 == 0)
			result->Add("Buzz");
		else
			result->Add(i.ToString());
	}
	return result;
}

IList<String^>^ LeetCode::FizzBuzz2(int n)
{
	array<String^>^ result = gcnew array<String^>(n);
	for (int i = 1; i <= n; i++)
	{
		if (i % 3 == 0 && i % 5 == 0)
			result[i - 1] = "FizzBuzz";
		else if (i % 3 == 0)
			result[i - 1] = "Fizz";
		else if (i % 5 == 0)
			result[i - 1] = "Buzz";
		else
			result[i - 1] = i.ToString();
	}
	return Enumerable::ToList<String^>(result);
}

IList<String^>^ LeetCode::FizzBuzz3(int n)
{
	array<String^>^ result = gcnew array<String^>(n);
	for (int i = 0; i < n; i++)
	{
		bool byThree = (i + 1) % 3 == 0;
		bool byFive = (i + 1) % 5 == 0;
		if (byThree || byFive)
		{
			if (byThree)
				result[i] += "Fizz";
			if (byFive)
				result[i] += "Buzz";
		}
		else
			result[i] = (i + 1).ToString();
	}
	return Enumerable::ToList<String^>(result);
}

IList<String^>^ LeetCode::FizzBuzz4(int n)
{
	array<String^>^ result = gcnew array<String^>(n);
	for (int i = 0; i < n; i++)
	{
		bool byThree = (i + 1) % 3 == 0;
		bool byFive = (i + 1) % 5 == 0;
		if (byThree && byFive)
			result[i] = "FizzBuzz";
		else if (byThree)
			result[i] = "Fizz";
		else if (byFive)
			result[i] = "Buzz";
		else
			result[i] = (i + 1).ToString();
	}
	return Enumerable::ToList<String^>(result);
}

IList<String^>^ LeetCode::FizzBuzz5(int n)
{
	array<String^>^ result = gcnew array<String^>(n);
	for (int i = 0; i < n; i++)
	{
		int value = i + 1;
		bool byThree = value % 3 == 0;
		bool byFive = value % 5 == 0;
		if (byThree && byFive)
			result[i] = "FizzBuzz";
		else if (byThree)
			result[i] = "Fizz";
		else if (byFive)
			result[i] = "Buzz";
		else
			result[i] = value.ToString();
	}
	return Enumerable::ToList<String^>(result);
}

IList<String^>^ LeetCode::FizzBuzz6(int n)
{
	array<String^>^ result = gcnew array<String^>(n);
	for (int i = 0; i < n; i++)
	{
		int value = i + 1;
		bool byThree = value % 3 == 0;
		bool byFive = value % 5 == 0;
		if (byThree && byFive)
			result[i] = "FizzBuzz";
		else if (byThree)
			result[i] = "Fizz";
		else if (byFive)
			result[i] = "Buzz";
		else
			result[i] = value.ToString();
	}
	return Enumerable::ToList<String^>(result);
}

LeetCode::ListNode^ LeetCode::MiddleNode(ListNode^ head)
{
	if (head == nullptr || head->next == nullptr) return head;
	int items = Count(head);
	int mid = items / 2;
	ListNode^ curr = head;
	for (int i = 0; i < mid; i++)
		curr = curr->next;
	return curr;
}

bool LeetCode::IsPalindrome(ListNode^ head)
{
	ListNode^ back = gcnew ListNode();
	ListNode^ curr = head;
	if (curr == nullptr) return true;
	back->val = curr->val;
	curr = curr->next;
	while (curr != nullptr)
	{
		back = gcnew ListNode(curr->val, back);
		curr = curr->next;
	}
	curr = head;
	ListNode^ rev = back;
	while (curr != nullptr)
	{
		if (curr->val != rev->val) return false;
		curr = curr->next;
		rev = rev->next;
	}
	return true;
}

bool LeetCode::IsPalindrome2(ListNode^ head)
{
	if (head == nullptr || head->next == nullptr) return true;

	ListNode^ curr = head;
	ListNode^ rev = Reverse(head);
	while (curr != nullptr)
	{
		if (curr->val != rev->val)
			return false;
		curr = curr->next;
		rev = rev->next;
	}
	return true;
}

bool LeetCode::IsPalindrome3(ListNode^ head)
{
	if (head == nullptr || head->next == nullptr) return true;

	int midPoint = PalindromeCount(head) / 2 + 1;
	ListNode^ curr = head;
	ListNode^ rev = Reverse(head);
	int count = 0;
	while (curr != nullptr)
	{
		if (curr->val != rev->val)
			return false;
		if (count > midPoint) break; // past the midpoint so we are done
		curr = curr->next;
		rev = rev->next;
		count++;
	}
	return true;
}

LeetCode::ListNode^ LeetCode::AddTwoNumbers(ListNode^ l1, ListNode^ l2)
{
	if (l1 == nullptr) return l2;
	if (l2 == nullptr) return l1;
	int carry = 0;
	int a = l1->val;
	int b = l2->val;
	ListNode^ result = gcnew ListNode();
	while (l1 != nullptr || l2 != nullptr)
	{
		result->val = a + b + carry;
		if (result->val > 9)
		{
			carry = 1;
			result->val %= 10;
		}
		else
			carry = 0;
		if (l1 != nullptr)
		{
			l1 = l1->next;
			a = l1 == nullptr ? 0 : l1->val;
		}
		if (l2 != nullptr)
		{
			l2 = l2->next;
			b = l2 == nullptr ? 0 : l2->val;
		}
		if (l1 != nullptr || l2 != nullptr)
			result = gcnew ListNode(0, result);
		else if (carry > 0)
			result = gcnew ListNode(carry, result);
	}

	return Reverse(result);
}

double LeetCode::FindMedianSortedArrays(array<int>^ nums1, array<int>^ nums2)
{
	double result = 0;
	int arrayLenth = 0;
	if (nums1 != nullptr) arrayLenth += nums1->Length;
	if (nums2 != nullptr) arrayLenth += nums2->Length;
	if (arrayLenth == 0) return result;
	array<int>^ temp = gcnew array<int>(arrayLenth);
	int Start = 0;
	if (nums1 != nullptr)
	{
		Array::Copy(nums1, 0, temp, Start, nums1->Length);
		Start = nums1->Length;
	}
	if (nums2 != nullptr)
		Array::Copy(nums2, 0, temp, Start, nums2->Length);
	Array::Sort(temp);
	if (arrayLenth % 2 == 0)
	{
		int pos = (arrayLenth / 2) - 1;
		result = ((double)(temp[pos] + temp[pos + 1])) / 2;
	}
	else
	{
		result = temp[arrayLenth / 2];
	}

	return result;
}

LeetCode::ListNode^ LeetCode::Reverse(ListNode^ head)
{
	ListNode^ result = nullptr;
	ListNode^ curr = head;
	while (curr != nullptr)
	{
		result = gcnew ListNode(curr->val, result);
		curr = curr->next;
	}
	return result;
}

int LeetCode::Count(ListNode^ head)
{
	int result = 0;
	ListNode^ curr = head;
	while (curr != nullptr)
	{
		result++;
		curr = curr->next;
	}
	return result;
}

int LeetCode::PalindromeCount(ListNode^ head)
{
	int result = 0;
	ListNode^ curr = head;
	while (curr != nullptr)
	{
		result++;
		curr = curr->next;
	}
	return result;
}
