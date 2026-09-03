using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình sử dụng vòng lặp for để in bảng cửu chương của một số bất kỳ (ví dụ: 5). 
Gợi ý:
- Yêu cầu người dùng nhập vào một số nguyên n.
- Sử dụng vòng lặp for để in ra bảng cửu chương của số đó từ 1 đến 10.
*/
Console.Write("Nhập vào một số nguyên n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
