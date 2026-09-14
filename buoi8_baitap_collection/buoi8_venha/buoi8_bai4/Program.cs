using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> DemTanSuat(int[] nums)
    {
        Dictionary<int, int> tanSuat = new Dictionary<int, int>();

        foreach (int x in nums)
        {
            if (tanSuat.ContainsKey(x))
            {
                tanSuat[x]++;
            }
            else
            {
                tanSuat[x] = 1;
            }
        }

        return tanSuat;
    }

    static void Main()
    {
        int[] nums = { 20, 15, 20, 33, 15, 20 };

        Dictionary<int, int> result = DemTanSuat(nums);

        Console.WriteLine($"Mảng: [{string.Join(", ", nums)}]");
        Console.Write("Tần suất: ");

        foreach (var item in result)
        {
            Console.Write($"{{{item.Key}:{item.Value}}} ");
        }

        Console.WriteLine();
    }
}