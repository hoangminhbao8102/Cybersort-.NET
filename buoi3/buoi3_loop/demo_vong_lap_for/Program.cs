using System.Text;

/*
    Vòng lặp for trong C# được sử dụng để thực hiện một đoạn mã nhất định một số lần xác định.
    Cú pháp: for (khởi tạo; điều kiện; bước nhảy)
*/
Console.OutputEncoding = Encoding.UTF8;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Hello, World! Lần lặp thứ {i}");
}
