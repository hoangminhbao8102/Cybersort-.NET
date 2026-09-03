/*
Viết chương trình cho phép người dùng nhập vào một chuỗi ký tự bất kỳ. In ra kết quả chuỗi đó có phải là chuỗi đối xứng không?
Ví dụ 1: 
Nhập vào: tenet
In ra: Đây là chuỗi đối xứng
Ví dụ 2:
Nhập vào: techx
In ra: Đây không phải là chuỗi đối xứng
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
│ PROCESS    │ So sánh từng cặp ký tự đối xứng
│            │ từ hai đầu chuỗi bằng vòng lặp
└─────┬──────┘
	  │
┌─────▼──────┐
│ OUTPUT     │ In kết quả chuỗi đối xứng hoặc không
└────────────┘
*/
Console.Write("Nhập vào: ");
string input = Console.ReadLine() ?? "";
string result = "";
bool isPalindrome = true;

for (int index = 0; index < input.Length / 2; index++)
{
	if (input[index] != input[input.Length - 1 - index])
	{
		isPalindrome = false;
		break;
	}
}

if (isPalindrome)
{
	result = "Đây là chuỗi đối xứng";
}
else
{
	result = "Đây không phải là chuỗi đối xứng";
}
Console.WriteLine($"In ra: {result}");
