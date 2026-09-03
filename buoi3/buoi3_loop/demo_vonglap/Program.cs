using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*
    4 yếu tố của vòng lặp:
    1. Khởi tạo biến đếm
    2. Điều kiện dừng
    3. Cập nhật biến đếm
    4. Khối lệnh thực thi

    In ra màn hình chữ Hello World 10 lần
*/

int i = 0; // Khởi tạo biến đếm
while (i < 10) // Điều kiện dừng
{
    Console.WriteLine($"Hello World lần {i + 1}"); // Khối lệnh thực thi
    i++; // Cập nhật biến đếm
}
