/*
    Viết chương trình cho phép người dùng nhập vào 1 câu : đếm số lượng từ trong câu
    input: hôm nay trời mưa
    => output: 4 từ
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
