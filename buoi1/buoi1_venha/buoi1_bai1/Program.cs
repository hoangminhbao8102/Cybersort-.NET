using System.Text;

/*
Bài tập 1: Tính số ngày trong tuần và số ngày lẻ 
Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số ngày: ");
int totalDays = int.Parse(Console.ReadLine()!);
int weeks = totalDays / 7;
int remainingDays = totalDays % 7;
Console.WriteLine($"{totalDays} ngày tương đương với {weeks} tuần và {remainingDays} ngày lẻ.");
