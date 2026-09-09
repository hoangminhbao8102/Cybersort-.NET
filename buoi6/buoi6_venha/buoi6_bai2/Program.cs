/*
    lst_number = [2, 7, 11, 15]
    Mô tả: Tìm hai số trong một danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước.
    Ví dụ:
    Input: nums = [2, 7, 11, 15], target = 9
    Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9) ngược lại nếu không có
*/

int[] numbers = { 2, 7, 11, 15 };
int target = 9;
Dictionary<int, int> seenNumbers = new();
int firstIndex = -1;
int secondIndex = -1;

for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
{
    int complement = target - numbers[currentIndex];

    if (seenNumbers.TryGetValue(complement, out firstIndex))
    {
        secondIndex = currentIndex;
        break;
    }

    seenNumbers[numbers[currentIndex]] = currentIndex;
}

if (secondIndex == -1)
{
    Console.WriteLine("Không tìm thấy hai số có tổng bằng target.");
}
else
{
    Console.WriteLine($"[{firstIndex}, {secondIndex}]");
}
