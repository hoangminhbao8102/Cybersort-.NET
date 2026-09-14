using System;
using System.Linq;

class Program
{
    static (int[] tang, int[] giam) SapXepHaiChieu(int[] nums)
    {
        int[] tang = nums.ToArray();
        int[] giam = nums.ToArray();

        Array.Sort(tang);
        Array.Sort(giam);
        Array.Reverse(giam);

        return (tang, giam);
    }

    static void Main()
    {
        int[] nums = { 3, 1, 4, 1, 5 };

        var result = SapXepHaiChieu(nums);

        Console.WriteLine($"Mảng gốc: [{string.Join(", ", nums)}]");
        Console.WriteLine($"Tăng dần: [{string.Join(", ", result.tang)}]");
        Console.WriteLine($"Giảm dần: [{string.Join(", ", result.giam)}]");
    }
}
