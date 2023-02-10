using tests;
// See https://aka.ms/new-console-template for more information


/*
Console.WriteLine("Hello, World!");


var result = SumOneArray.RunningSum(new int[] { 1, 3, 4, 5 });

var sdtest = "sdfsdf";



var cool = FindPivotIndex.PivotIndex(new int[]{-1,-1,0,1,0,-1});
*/

// var test = PalindromeNumber.IsPalindrome(1221);


//var test = Isomorphic.IsIsomorphic("e", "a"); 

//var result = Subsequences.IsSubsequence("twn", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxtxxxxxxxxxxxxxxxxxxxxwxxxxxxxxxxxxxxxxxxxxxxxxxn");

ListNode l1 = new ListNode(0, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));
ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, null))));

var result = AddTwoNumbersLinkLists.AddTwoNumbers(l1, l2);