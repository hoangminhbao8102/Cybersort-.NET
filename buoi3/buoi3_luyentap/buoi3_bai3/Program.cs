using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
Viết chương trình sử dụng vòng lặp for để đảo ngược một chuỗi.
Gợi ý:
- Yêu cầu người dùng nhập vào một chuỗi.
- Sử dụng vòng lặp for để lặp qua từng ký tự của chuỗi từ cuối đến đầu.
- Tạo một chuỗi mới chứa các ký tự đảo ngược và in ra kết quả.
*/
Console.Write("Nhập vào một chuỗi: ");
string input = Console.ReadLine() ?? "";
string reversed = "";
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}
Console.WriteLine($"Chuỗi đảo ngược: {reversed}");
