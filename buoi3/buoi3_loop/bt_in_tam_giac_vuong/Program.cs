using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình cho phép người dùng nhập vào số n, sau đó in tam giác vuông.
Ví dụ: n = 3 
=> 
*
**
***
*/
Console.Write("Nhập vào số n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*\t");
    }
    Console.WriteLine();
}
