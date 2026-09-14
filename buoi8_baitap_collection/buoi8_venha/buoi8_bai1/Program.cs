using System;

class Program
{
    static long TongLonHon(int[] nums, int moc)
    {
        long tong = 0;

        foreach (int so in nums)
        {
            if (so > moc)
            {
                tong += so;
            }
        }

        return tong;
    }

    static void Main()
    {
        int[] nums = { 20, 81, 97, 63, 72, 11 };
        int moc = 50;

        long ketQua = TongLonHon(nums, moc);

        Console.WriteLine("Mảng: [20, 81, 97, 63, 72, 11]");
        Console.WriteLine($"moc = {moc}");
        Console.WriteLine($"Tổng các phần tử lớn hơn {moc} là: {ketQua}");
    }
}
