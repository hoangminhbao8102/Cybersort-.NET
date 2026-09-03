/*
Viết chương trình cho phép người dùng nhập vào một chuỗi, in ra chuỗi đó được loại bỏ khoảng trắng.
Ví dụ: 
Nhập vào: chuoi nay khong co khoang trang
In ra: chuoinaykhongcokhoangtrang
- Lập sơ đồ 3 khối xác định input output process.
- Viết code giải quyết bài toán không dùng thư viện hay các hàm xử lý chuỗi có sẵn ví dụ: str.replace(" ","")
- Hãy dùng vòng lặp để tư duy xử lý.
*/
/*
Sơ đồ 3 khối:
+------------+
| INPUT      | Nhập chuỗi s
+-----+------+
	  |
+-----v------+
| PROCESS    | Duyệt từng ký tự và nối vào kết quả
|            | nếu ký tự đó không phải khoảng trắng
+-----+------+
	  |
+-----v------+
| OUTPUT     | In chuỗi đã loại bỏ khoảng trắng
+------------+
*/
Console.Write("Nhập vào: ");
string input = Console.ReadLine() ?? "";
string result = "";

for (int index = 0; index < input.Length; index++)
{
	if (input[index] != ' ')
	{
		result += input[index];
	}
}

Console.WriteLine("In ra: " + result);
