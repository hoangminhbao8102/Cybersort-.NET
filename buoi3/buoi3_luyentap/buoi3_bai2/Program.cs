using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình sử dụng vòng lặp for để tìm tất cả các số nguyên tố trong khoảng từ 1 đến 50.
Gợi ý:
- Sử dụng một vòng lặp for để lặp qua các số từ 2 đến n.
- Trong mỗi lần lặp, sử dụng một vòng lặp for khác để kiểm tra xem số đó có phải là số nguyên tố không.
- In ra các số nguyên tố tìm được.
*/
for (int i = 2; i <= 50; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write($"{i} ");
    }
}
