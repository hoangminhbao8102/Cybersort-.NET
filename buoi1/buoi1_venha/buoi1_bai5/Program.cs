using System.Text;

/*
Bài tập 5: Chuyển đổi đơn vị tiền tệ
Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND. Tính và in ra số tiền tương ứng bằng VND.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số tiền bằng USD: ");
double usdAmount = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập tỷ giá chuyển đổi từ USD sang VND: ");
double exchangeRate = double.Parse(Console.ReadLine() ?? "0");
double vndAmount = usdAmount * exchangeRate;
Console.WriteLine($"Số tiền tương ứng bằng VND: {vndAmount:F2}");
