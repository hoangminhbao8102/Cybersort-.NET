using System.Text;

/*
🪖 Tình huống – “Kiểm tra độ tuổi tham gia nghĩa vụ quân sự”
Bạn được giao xây dựng một chương trình hỗ trợ cho cán bộ xã trong việc rà soát danh sách thanh niên đủ điều kiện tham gia nghĩa vụ quân sự.
Cán bộ sẽ nhập tuổi của công dân, và hệ thống sẽ phân loại kết quả như sau:
- Nếu dưới 18 tuổi → ❌ Chưa đủ tuổi tham gia NVQS
- Nếu từ 18 đến 27 tuổi → ✅ Đủ tuổi tham gia NVQS
- Nếu trên 27 tuổi → ⛔ Quá tuổi tham gia NVQS
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào độ tuổi: ");
int age = int.Parse(Console.ReadLine() ?? "0");

if (age < 18)
{
    Console.WriteLine("❌ Chưa đủ tuổi tham gia NVQS");
}
else if (age >= 18 && age <= 27)
{
    Console.WriteLine("✅ Đủ tuổi tham gia NVQS");
}
else
{
    Console.WriteLine("⛔ Quá tuổi tham gia NVQS");
}
