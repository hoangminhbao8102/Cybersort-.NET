using System.Text;

/*
💡 Tình huống – “Tính tiền điện cho hộ gia đình”
Bạn đang xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình. Khi người dùng nhập vào số điện tiêu thụ trong tháng (tính bằng kWh), chương trình sẽ tính tiền điện phải trả theo biểu giá đơn giản hóa sau:
- Dưới 100 kWh: 1.500 VND/kWh
- Từ 100 đến 200 kWh: 2.000 VND/kWh
- Trên 200 kWh: 2.500 VND/kWh
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào số điện tiêu thụ (kWh): ");
int consumption = int.Parse(Console.ReadLine() ?? "0");

double bill = 0;

if (consumption < 100)
{
    bill = consumption * 1500;
}
else if (consumption < 200)
{
    bill = 100 * 1500 + (consumption - 100) * 2000;
}
else
{
    bill = 100 * 1500 + 100 * 2000 + (consumption - 200) * 2500;
}

Console.WriteLine($"Tiền điện phải trả: {bill:N0} VND");
