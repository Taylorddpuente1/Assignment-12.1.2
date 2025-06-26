
using System;
using System.Collections.Generic;

public class ListNode
{
 
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> values = new List<int>();

      
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        
        int left = 0;
        int right = values.Count - 1;

        while (left < right)
        {
            if (values[left] != values[right])
                return false;
            left++;
            right--;
        }

        return true;
    }
}
public static class Program
{
    public static void Main(string[] args)
    {

        ListNode head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))));
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(head)); // Output: true
    }
}