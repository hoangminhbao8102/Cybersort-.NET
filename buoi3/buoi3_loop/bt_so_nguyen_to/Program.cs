using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
    Viết chương trình cho phép người dùng nhập vào một số n, sau đó kiểm tra xem n có phải là số nguyên tố hay không
    Ví dụ: n = 5 => 5 là số nguyên tố

    Kỹ thuật đặt cờ hiệu (hay còn gọi là lính canh) là một kỹ thuật lập trình được sử dụng để kiểm tra điều kiện trong một vòng lặp.
    Cờ hiệu là một biến boolean được sử dụng để theo dõi trạng thái của một điều kiện trong quá trình thực hiện vòng lặp.
    Khi điều kiện được thỏa mãn, cờ hiệu sẽ được đặt thành true, và khi điều kiện không được thỏa mãn, cờ hiệu sẽ được đặt thành false.
*/
Console.Write("Nhập số nguyên dương n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (n < 2)
{
    Console.WriteLine($"{n} không phải là số nguyên tố.");
    return;
}
bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine($"{n} là số nguyên tố.");
}
else
{
    Console.WriteLine($"{n} không phải là số nguyên tố.");
}
