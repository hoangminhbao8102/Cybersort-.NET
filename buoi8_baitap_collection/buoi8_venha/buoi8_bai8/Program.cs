using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, int> ThongKeXepLoai(double[] diem)
    {
        Dictionary<string, int> ketQua = new Dictionary<string, int>
        {
            ["Giỏi"] = 0,
            ["Khá"] = 0,
            ["Trung bình"] = 0,
            ["Yếu"] = 0
        };

        foreach (double d in diem)
        {
            if (d >= 8)
                ketQua["Giỏi"]++;
            else if (d >= 6.5)
                ketQua["Khá"]++;
            else if (d >= 5)
                ketQua["Trung bình"]++;
            else
                ketQua["Yếu"]++;
        }

        return ketQua;
    }

    static void Main()
    {
        double[] diem = { 9, 7, 5, 4, 8.5, 6 };

        Dictionary<string, int> result = ThongKeXepLoai(diem);

        Console.WriteLine($"Điểm: [{string.Join(", ", diem)}]");
        Console.WriteLine($"Giỏi: {result["Giỏi"]}");
        Console.WriteLine($"Khá: {result["Khá"]}");
        Console.WriteLine($"Trung bình: {result["Trung bình"]}");
        Console.WriteLine($"Yếu: {result["Yếu"]}");
    }
}