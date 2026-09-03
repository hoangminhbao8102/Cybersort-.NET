using System.Text;

/*
Bài tập 8: Tính tỷ lệ phần trăm
Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính và in ra tỷ lệ phần trăm của số đó trong tổng số.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào một số: ");
double so = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập vào tổng số: ");
double tongSo = double.Parse(Console.ReadLine() ?? "0");
double tyLe = (so / tongSo) * 100;
Console.WriteLine($"Tỷ lệ phần trăm của {so} trong {tongSo} là: {tyLe:F2}%");
