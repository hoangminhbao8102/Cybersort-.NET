/*
Viết chương trình cho phép người dùng nhập vào một câu đếm số lượng từ trong câu đó.
Ví dụ: 
Nhập vào: toi la lap trinh vien
In ra: 5
- Lập sơ đồ 3 khối xác định input output process.
- Viết code giải quyết bài toán không dùng thư viện hay các hàm xử lý chuỗi có sẵn.
- Hãy dùng vòng lặp để tư duy xử lý.
*/
/*
Sơ đồ 3 khối:
+------------+
| INPUT      | Nhập câu s
+-----+------+
	  |
+-----v------+
| PROCESS    | Duyệt từng ký tự, đếm ký tự đầu tiên
|            | của mỗi từ sau dấu cách
+-----+------+
	  |
+-----v------+
| OUTPUT     | In số lượng từ
+------------+
*/
Console.Write("Nhập vào: ");
string input = Console.ReadLine() ?? "";
int wordCount = 0;
bool isInsideWord = false;

for (int index = 0; index < input.Length; index++)
{
	if (input[index] == ' ')
	{
		isInsideWord = false;
	}
	else if (!isInsideWord)
	{
		wordCount++;
		isInsideWord = true;
	}
}

Console.WriteLine("In ra: " + wordCount);
