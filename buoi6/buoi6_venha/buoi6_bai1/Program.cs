/*
    lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20]
    Bài toán: Tính tổng của các số trong một mảng.
    Mô tả: Bạn được cung cấp một mảng số nguyên lstNumber. Nhiệm vụ của bạn là tính tổng của tất cả các số trong mảng này
    Input: lstNumber: Một danh sách (mảng) chứa các số nguyên. Đây là mảng bạn cần tính tổng.
    Output: Trả về tổng của tất cả các số trong mảng lstNumber
*/

int[] lstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
int total = 0;

foreach (int number in lstNumber)
{
    total += number;
}

Console.WriteLine($"Tổng các phần tử trong mảng là: {total}");
