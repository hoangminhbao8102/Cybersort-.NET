/*
Viết chương trình cho phép người dùng nhập vào một chuỗi ký tự bất kỳ. In ra chuỗi đảo ngược tương ứng.
Ví dụ: 
Nhập vào: hello techx
In ra: xhcet olleh
- Lập sơ đồ 3 khối xác định input output process.
- Viết code giải quyết bài toán không dùng thư viện hay các hàm xử lý chuỗi có sẵn. Ví dụ: s[::-1]
- Hãy dùng vòng lặp để tư duy xử lý.
*/
/*
Sơ đồ 3 khối:
┌────────────┐
│ INPUT      │ Nhập chuỗi s
└─────┬──────┘
	│
┌─────▼──────┐
│ PROCESS    │ Duyệt từ ký tự cuối về ký tự đầu
│            │ và ghép vào chuỗi đảo ngược
└─────┬──────┘
	│
┌─────▼──────┐
│ OUTPUT     │ In chuỗi đảo ngược
└────────────┘
*/
Console.Write("Nhập vào: ");
string input = Console.ReadLine() ?? "";
string reversed = "";

for (int index = input.Length - 1; index >= 0; index--)
{
    reversed += input[index];
}

Console.WriteLine("In ra: " + reversed);
