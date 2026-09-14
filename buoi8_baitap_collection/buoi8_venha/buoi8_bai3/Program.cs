using System;
using System.Collections.Generic;

class Program
{
    static int[] LoaiTrung(int[] nums)
    {
        HashSet<int> daGap = new HashSet<int>();
        List<int> ketQua = new List<int>();

        foreach (int x in nums)
        {
            if (!daGap.Contains(x))
            {
                daGap.Add(x);
                ketQua.Add(x);
            }
        }

        return ketQua.ToArray();
    }

    static void Main()
    {
        int[] nums = { 1, 2, 2, 3, 3, 3, 1 };

        int[] result = LoaiTrung(nums);

        Console.WriteLine($"Mảng gốc: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Mảng sau khi loại trùng: [{string.Join(", ", result)}]");
    }
}