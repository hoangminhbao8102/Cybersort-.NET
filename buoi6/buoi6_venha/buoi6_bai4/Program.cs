/*
    lstNumber = [1, 1, 1, 2, 2, 3]
    Remove Duplicates from Sorted Array (Easy):
    Mô tả: Cho một mảng số nguyên, tìm k phần tử xuất hiện nhiều lần nhất trong mảng và trả về chúng dưới dạng danh sách. Nếu có nhiều phần tử có cùng tần số xuất hiện, trả về bất kỳ trong số chúng.
    Ví dụ:
    Input: nums = [1, 1, 1, 2, 2, 3], k = 2
    Output: [1, 2]
    Giải thích: Trong mảng nums, số 1 xuất hiện 3 lần, số 2 xuất hiện 2 lần và số 3 xuất hiện 1 lần. Ta cần trả về 2 phần tử xuất hiện nhiều lần nhất và chúng có thể là 1 và 2 (hoặc 2 và 1)
    Lưu ý:
    - Kết quả có thể được trả về dưới bất kỳ thứ tự nào.
    - Số lần xuất hiện của các phần tử không cần phải theo tứ tự tăng dần.
*/

int[] numbers = { 1, 1, 1, 2, 2, 3 };
int k = 2;
Dictionary<int, int> frequencies = new();

foreach (int number in numbers)
{
    frequencies[number] = frequencies.GetValueOrDefault(number) + 1;
}

int resultCount = Math.Min(k, frequencies.Count);
int[] mostFrequentNumbers = new int[resultCount];
HashSet<int> selectedNumbers = new();

for (int resultIndex = 0; resultIndex < resultCount; resultIndex++)
{
    int mostFrequentNumber = 0;
    int highestFrequency = -1;

    foreach (KeyValuePair<int, int> entry in frequencies)
    {
        if (!selectedNumbers.Contains(entry.Key) && entry.Value > highestFrequency)
        {
            mostFrequentNumber = entry.Key;
            highestFrequency = entry.Value;
        }
    }

    mostFrequentNumbers[resultIndex] = mostFrequentNumber;
    selectedNumbers.Add(mostFrequentNumber);
}

Console.WriteLine($"{k} phần tử xuất hiện nhiều nhất: [{string.Join(", ", mostFrequentNumbers)}]");
