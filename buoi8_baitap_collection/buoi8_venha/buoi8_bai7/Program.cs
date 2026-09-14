using System;
using System.Collections.Generic;

class Program
{
    static int LonThuHai(int[] nums)
    {
        HashSet<int> values = new HashSet<int>(nums);

        if (values.Count < 2)
            return int.MinValue;

        List<int> distinct = new List<int>(values);
        distinct.Sort();

        return distinct[distinct.Count - 2];
    }

    static void Main()
    {
        int[] nums = { 20, 97, 81, 97, 63 };

        int result = LonThuHai(nums);

        Console.WriteLine($"Mảng: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Giá trị lớn thứ hai khác nhau: {result}");
    }
}