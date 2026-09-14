using System;
using System.Collections.Generic;

class Program
{
    static int[] Giao(int[] a, int[] b)
    {
        HashSet<int> setB = new HashSet<int>(b);
        HashSet<int> daThem = new HashSet<int>();
        List<int> ketQua = new List<int>();

        foreach (int x in a)
        {
            if (setB.Contains(x) && !daThem.Contains(x))
            {
                daThem.Add(x);
                ketQua.Add(x);
            }
        }

        return ketQua.ToArray();
    }

    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 3, 4, 5 };

        int[] result = Giao(a, b);

        Console.WriteLine($"a = [{string.Join(", ", a)}]");
        Console.WriteLine($"b = [{string.Join(", ", b)}]");
        Console.WriteLine($"Giao = [{string.Join(", ", result)}]");
    }
}