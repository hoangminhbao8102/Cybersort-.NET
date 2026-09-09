List<string> lstStrings = ["apple", "banana", "orange", "kiwi", "mango", "pineapple", "grape", "melon"];

// Bài 1: Tính độ dài của mảng
Console.WriteLine($"Số lượng chuỗi: {lstStrings.Count}");

// Bài 2: In ra các chuỗi dài hơn 5 ký tự
List<string> longerThanFive = [];
foreach (string item in lstStrings)
{
	if (item.Length > 5)
	{
		longerThanFive.Add(item);
	}
}
Console.WriteLine("Chuỗi dài hơn 5 ký tự: " + string.Join(", ", longerThanFive));

// Bài 3: Tìm chuỗi dài nhất trong mảng
string longestString = string.Empty;
foreach (string item in lstStrings)
{
	if (item.Length > longestString.Length)
	{
		longestString = item;
	}
}
Console.WriteLine($"Chuỗi dài nhất: {longestString}");

// Bài 4: In ra các chuỗi có chứa chữ 'a'
List<string> containingA = [];
foreach (string item in lstStrings)
{
	if (item.Contains('a'))
	{
		containingA.Add(item);
	}
}
Console.WriteLine("Chuỗi có chứa chữ 'a': " + string.Join(", ", containingA));

// Bài 5: Tìm chuỗi bắt đầu bằng chữ 'm'
List<string> startingWithM = [];
foreach (string item in lstStrings)
{
	if (item.StartsWith('m'))
	{
		startingWithM.Add(item);
	}
}
Console.WriteLine("Chuỗi bắt đầu bằng chữ 'm': " + string.Join(", ", startingWithM));

// Bài 6: Đếm số chuỗi có độ dài nhỏ hơn 6 ký tự
int shorterThanSixCount = 0;
foreach (string item in lstStrings)
{
	if (item.Length < 6)
	{
		shorterThanSixCount++;
	}
}
Console.WriteLine($"Số chuỗi có độ dài nhỏ hơn 6 ký tự: {shorterThanSixCount}");

// Bài 7: In ra chuỗi dài thứ hai trong mảng
string longestStringForSecond = string.Empty;
string secondLongestString = string.Empty;
foreach (string item in lstStrings)
{
	if (item.Length > longestStringForSecond.Length)
	{
		secondLongestString = longestStringForSecond;
		longestStringForSecond = item;
	}
	else if (item.Length > secondLongestString.Length)
	{
		secondLongestString = item;
	}
}
Console.WriteLine($"Chuỗi dài thứ hai: {secondLongestString}");

// Bài 8: Sắp xếp mảng theo thứ tự bảng chữ cái
lstStrings.Sort(StringComparer.Ordinal);
Console.WriteLine("Sắp xếp theo alphabet: " + string.Join(", ", lstStrings));

// Bài 9: Chuyển tất cả các chuỗi thành chữ hoa
for (int index = 0; index < lstStrings.Count; index++)
{
	lstStrings[index] = lstStrings[index].ToUpperInvariant();
}
Console.WriteLine("Chuỗi viết hoa: " + string.Join(", ", lstStrings));

// Bài 10: Thay thế chuỗi "banana" bằng "pear"
int bananaIndex = lstStrings.FindIndex(item => item.Equals("BANANA", StringComparison.OrdinalIgnoreCase));
if (bananaIndex >= 0)
{
	lstStrings[bananaIndex] = "pear";
}
Console.WriteLine("Sau khi thay thế 'banana': " + string.Join(", ", lstStrings));
