using System.Text;

/*
🧭 Tình huống – “Xác định mùa trong năm từ số tháng”
Hãy xây dựng một chức năng cho ứng dụng lịch Việt Nam. Khi người dùng nhập vào số tháng (từ 1 đến 12), chương trình cần xác định xem tháng đó thuộc mùa nào trong năm:
- Xuân: Tháng 1, 2, 3
- Hạ: Tháng 4, 5, 6
- Thu: Tháng 7, 8, 9
- Đông: Tháng 10, 11, 12
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào số tháng (1-12): ");
int month = int.Parse(Console.ReadLine() ?? "1");

string season = "";

if (month >= 1 && month <= 3)
{
    season = "Xuân";
}
else if (month >= 4 && month <= 6)
{
    season = "Hạ";
}
else if (month >= 7 && month <= 9)
{
    season = "Thu";
}
else if (month >= 10 && month <= 12)
{
    season = "Đông";
}

Console.WriteLine($"Tháng {month} thuộc mùa {season}");
