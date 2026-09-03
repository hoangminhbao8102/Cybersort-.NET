using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
    Viết chương trình cho phép người dùng nhập vào một số n, sau đó tính tổng các số từ 2 đến 2n
    Ví dụ: n = 5 => 2 + 4 + 6 + 8 + 10 = 30

    Xác định 4 yếu tố của vòng lặp:
    1. Khởi tạo biến đếm
    2. Điều kiện dừng
    3. Cập nhật biến đếm
    4. Khối lệnh thực thi
*/
Console.Write("Nhập vào một số n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = 0; // Khởi tạo biến tổng
int i = 2; // Khởi tạo biến đếm
while (i <= 2 * n) // Điều kiện dừng
{
    if (i % 2 == 0) // Kiểm tra nếu i là số chẵn
    {
        sum += i; // Khối lệnh thực thi
    }
    i++; // Cập nhật biến đếm
}
Console.WriteLine($"Tổng các số từ 2 đến {2 * n} là: {sum}");
