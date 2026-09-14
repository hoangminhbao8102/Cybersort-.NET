using System;
using System.Collections.Generic;

class Program
{
    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int x in nums)
        {
            if (!set.Add(x))
            {
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 1 };
        int[] nums2 = { 1, 2, 3, 4 };

        Console.WriteLine($"Input 1: [{string.Join(", ", nums1)}] -> Output 1: {ContainsDuplicate(nums1)}");
        Console.WriteLine($"Input 2: [{string.Join(", ", nums2)}] -> Output 2: {ContainsDuplicate(nums2)}");
    }
}