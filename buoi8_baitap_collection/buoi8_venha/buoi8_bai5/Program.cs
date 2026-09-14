using System;
using System.Collections.Generic;

class Program
{
    static int[] Hop(int[] a, int[] b)
    {
        HashSet<int> daGap = new HashSet<int>();
        List<int> ketQua = new List<int>();

        foreach (int x in a)
        {
            if (!daGap.Contains(x))
            {
                daGap.Add(x);
                ketQua.Add(x);
            }
        }

        foreach (int x in b)
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
        int[] a = { 1, 2, 3 };
        int[] b = { 3, 4, 5 };

        int[] result = Hop(a, b);

        Console.WriteLine($"a = [{string.Join(", ", a)}]");
        Console.WriteLine($"b = [{string.Join(", ", b)}]");
        Console.WriteLine($"Hợp = [{string.Join(", ", result)}]");
    }
}