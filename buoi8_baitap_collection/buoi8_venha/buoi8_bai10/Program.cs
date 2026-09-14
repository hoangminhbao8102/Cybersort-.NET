using System;
using System.Collections.Generic;

class Program
{
    static int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> dem = new Dictionary<int, int>();
        dem[0] = 1;

        int tong = 0;
        int ketQua = 0;

        foreach (int x in nums)
        {
            tong += x;

            int target = tong - k;
            if (dem.ContainsKey(target))
            {
                ketQua += dem[target];
            }

            if (dem.ContainsKey(tong))
            {
                dem[tong]++;
            }
            else
            {
                dem[tong] = 1;
            }
        }

        return ketQua;
    }

    static void Main()
    {
        int[] nums1 = { 1, 1, 1 };
        int[] nums2 = { 1, 2, 3 };

        Console.WriteLine($"Input 1: [{string.Join(", ", nums1)}], k = 2 -> Output 1: {SubarraySum(nums1, 2)}");
        Console.WriteLine($"Input 2: [{string.Join(", ", nums2)}], k = 3 -> Output 2: {SubarraySum(nums2, 3)}");
    }
}