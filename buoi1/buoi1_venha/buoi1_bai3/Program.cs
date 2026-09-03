using System.Text;

/*
Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút
Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ và phút. Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số phút: ");
int totalMinutes = int.Parse(Console.ReadLine() ?? "0");
int hours = totalMinutes / 60;
int minutes = totalMinutes % 60;
Console.WriteLine($"{totalMinutes} phút tương đương với {hours} giờ và {minutes} phút.");
