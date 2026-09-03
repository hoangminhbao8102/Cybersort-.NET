using System.Text;

/*
🚕 Tình huống – “Tính tiền taxi cho khách hàng”
Bạn đang viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi. Biểu giá tính như sau:
- 1 km đầu tiên: 10.000 VND
- Từ km thứ 2 đến km thứ 5: 8.000 VND/km
- Từ km thứ 6 trở đi: 6.000 VND/km
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào số km khách hàng đã đi: ");
int distance = int.Parse(Console.ReadLine() ?? "0");

double fare = 0;

if (distance == 1)
{
    fare = 10000;
}
else if (distance <= 5)
{
    fare = 10000 + (distance - 1) * 8000;
}
else
{
    fare = 10000 + 4 * 8000 + (distance - 5) * 6000;
}

Console.WriteLine($"Tiền taxi phải trả: {fare:N0} VND");
