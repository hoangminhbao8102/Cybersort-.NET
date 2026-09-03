using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình cho phép người dùng nhập vào số n, sau đó in tam giác cân.
Ví dụ: n = 3 
=> 
  *
 ***
*****
*/
Console.Write("Nhập vào số n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
