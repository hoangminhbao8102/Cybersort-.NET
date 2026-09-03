using System.Text;

/*
 * Bài tập 1: Viết chương trình nhập vào nhiệt độ (độ C) và in ra nhiệt độ tương ứng (độ F)
 * Công thức chuyển đổi: F = C * 9/5 + 32
 * Hiển thị:
 Bạn nhập nhiệt độ (độ C): 25
 Nhiệt độ tương ứng (độ F): 77
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Bạn nhập nhiệt độ (độ C): ");
double doC = Convert.ToDouble(Console.ReadLine());
//double doC = double.Parse(Console.ReadLine() ?? "0");
double doF = doC * 9 / 5 + 32;
Console.WriteLine($"Nhiệt độ tương ứng (độ F): {doF}");
