using System.Text;

/*
Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). Tính và in ra tổng số tiền sau khi đã cộng thêm thuế
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số tiền gốc: ");
double baseAmount = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập tỷ lệ thuế VAT (ví dụ: 10 cho 10%): ");
double vatRate = double.Parse(Console.ReadLine() ?? "0");
double totalAmount = baseAmount + (baseAmount * vatRate / 100);
Console.WriteLine($"Tổng số tiền sau khi cộng thêm thuế VAT: {totalAmount:F2}");
