using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
    Viết chương trình cho phép người dùng nhập vào một số n, sau đó tính giai thừa các số từ 1 đến n
    Ví dụ: n = 5 => 1 * 2 * 3 * 4 * 5 = 120

    Xác định 4 yếu tố của vòng lặp:
    1. Khởi tạo biến đếm
    2. Điều kiện dừng
    3. Cập nhật biến đếm
    4. Khối lệnh thực thi
*/
Console.Write("Nhập vào số n: ");
int n = Convert.ToInt32(Console.ReadLine());

long giaiThua = 1;
for (int i = 1; i <= n; i++)
{
    giaiThua *= i;
}
Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
