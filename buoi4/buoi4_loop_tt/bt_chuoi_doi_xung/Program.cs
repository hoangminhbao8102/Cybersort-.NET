/*
    Viết chương trình cho pháp người dùng nhập vào 1 chuỗi -> Kiểm tra chuỗi có phải là chuỗi đối xứng hay không
    
    string = heeh; đối xứng h = h e = e
    string = cyber; không đối xứng c ! r
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
