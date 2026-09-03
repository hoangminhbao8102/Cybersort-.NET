using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
    Viết chương trình cho phép người dùng nhập vào một số n, sau đó tính tổng các số từ 1 đến n
    Ví dụ: n = 5 => 1 + 2 + 3 + 4 + 5 = 15

    Xác định 4 yếu tố của vòng lặp:
    1. Khởi tạo biến đếm
    2. Điều kiện dừng
    3. Cập nhật biến đếm
    4. Khối lệnh thực thi
*/
Console.Write("Nhập vào một số n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int sum = 0; // Khởi tạo biến tổng
int i = 1; // Khởi tạo biến đếm
while (i <= n) // Điều kiện dừng
{
    sum += i; // Khối lệnh thực thi
    i++; // Cập nhật biến đếm
}
Console.WriteLine($"Tổng các số từ 1 đến {n} là: {sum}");
