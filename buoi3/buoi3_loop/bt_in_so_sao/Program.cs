using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình cho phép người dùng nhập vào số n, sau đó in ra n sao tương ứng.
Ví dụ: n = 5 và m = 3 
=> 
*****
*****
*****
*/
#region In 1 hàng sao
Console.Write("Nhập số cột n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
for (int i = 1; i <= n; i++)
{
    Console.Write("*\t");
}
Console.WriteLine();
#endregion
#region In nhiều hàng sao
Console.Write("Nhập số cột c: ");
int c = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập số hàng r: ");
int r = int.Parse(Console.ReadLine() ?? "0");
for (int j = 1; j <= r; j++)
{
    for (int i = 1; i <= c; i++)
    {
        Console.Write("*\t");
    }
    Console.WriteLine();
}
#endregion
