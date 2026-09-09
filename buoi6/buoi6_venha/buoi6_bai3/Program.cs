/*
    lstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]
    Remove Duplicates from Sorted Array (Easy):
    Mô tả: Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới.
    Ví dụ:
    Input: nums = [1, 1, 2, 2, 2, 3, 4, 4, 5]
    Output: 5 (mảng mới là [1, 2, 3, 4, 5])
*/

int[] numbers = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
int uniqueCount = numbers.Length == 0 ? 0 : 1;

for (int currentIndex = 1; currentIndex < numbers.Length; currentIndex++)
{
    if (numbers[currentIndex] != numbers[uniqueCount - 1])
    {
        numbers[uniqueCount] = numbers[currentIndex];
        uniqueCount++;
    }
}

Console.WriteLine($"Số phần tử sau khi loại trùng: {uniqueCount}");
Console.WriteLine($"Mảng mới: [{string.Join(", ", numbers[..uniqueCount])}]");
