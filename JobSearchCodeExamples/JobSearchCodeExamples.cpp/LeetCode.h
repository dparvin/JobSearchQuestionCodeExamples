#pragma once

#include <string>
#include <vector>
#using <System.dll>

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Linq;

public ref class LeetCode
{
public:
	ref struct ListNode
	{
		int val;
		ListNode^ next;
		ListNode() : val(0), next(nullptr) {}
		ListNode(int x) : val(x), next(nullptr) {}
		ListNode(int x, ListNode^ next) : val(x), next(next) {}
	};

	static IList<String^>^ FizzBuzz(int n);
	static IList<String^>^ FizzBuzz2(int n);
	static IList<String^>^ FizzBuzz3(int n);
	static IList<String^>^ FizzBuzz4(int n);
	static IList<String^>^ FizzBuzz5(int n);
	static IList<String^>^ FizzBuzz6(int n);

	static ListNode^ MiddleNode(ListNode^ head);

	static bool IsPalindrome(ListNode^ head);
	static bool IsPalindrome2(ListNode^ head);
	static bool IsPalindrome3(ListNode^ head);

	static ListNode^ AddTwoNumbers(ListNode^ l1, ListNode^ l2);

	static double FindMedianSortedArrays(array<int>^ nums1, array<int>^ nums2);

private:
	static ListNode^ Reverse(ListNode^ head);
	static int Count(ListNode^ head);
	static int PalindromeCount(ListNode^ head);
};

