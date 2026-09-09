using System.Text.Json;

List<int> lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];

// Bài 1: Tính tổng các số lớn hơn 50 trong danh sách
Func<List<int>, int> tinhTongPhanTu = (lst) =>
{
    // Output: tổng các số lớn hơn 50 trong lstNumber
    int sum = 0;
    // Process: Duyệt qua từng phần tử trong lstNumber, nếu phần tử lớn hơn 50 thì cộng vào sum
    foreach (int num in lst)
    {
        if (num > 50)
        {
            sum += num;
        }
    }
    return sum;
};

Console.WriteLine($"Tổng các số lớn hơn 50 trong danh sách là: {tinhTongPhanTu(lstNumber)}");

// Bài 2: Đếm số phần tử lớn hơn 30
Func<List<int>, int> demPhanTuLonHon30 = (lst) =>
{
    int count = 0;
    foreach (int num in lst)
    {
        if (num > 30)
        {
            count++;
        }
    }
    return count;
};

Console.WriteLine($"Số phần tử lớn hơn 30 trong danh sách là: {demPhanTuLonHon30(lstNumber)}");

// Bài 3: Tìm số lớn nhất trong danh sách
Func<List<int>, int> timSoLonNhat = (lst) =>
{
    int max = lst[0];
    foreach (int num in lst)
    {
        if (num > max)
        {
            max = num;
        }
    }
    return max;
};

Console.WriteLine($"Số lớn nhất trong danh sách là: {timSoLonNhat(lstNumber)}");

// Bài 4: Tính trung bình cộng của các số lẻ
Func<List<int>, double> tinhTrungBinhCongSoLe = (lst) =>
{
    double sum = 0;
    int count = 0;
    foreach (int num in lst)
    {
        if (num % 2 != 0)
        {
            sum += num;
            count++;
        }
    }
    return count > 0 ? sum / count : 0;
};

Console.WriteLine($"Trung bình cộng của các số lẻ trong danh sách là: {tinhTrungBinhCongSoLe(lstNumber)}");

// Bài 5: In ra các số chẵn trong danh sách
Console.WriteLine("Các số chẵn trong danh sách là:");
foreach (int num in lstNumber)
{
    if (num % 2 == 0)
    {
        Console.Write($"{num} ");
    }
}
Console.WriteLine();

// Bài 6: Tìm vị trí đầu tiên của số 20 trong danh sách
Func<List<int>, int> timViTriDauTienCua20 = (lst) =>
{
    for (int i = 0; i < lst.Count; i++)
    {
        if (lst[i] == 20)
        {
            return i;
        }
    }
    return -1; // Trả về -1 nếu không tìm thấy
};

Console.WriteLine($"Vị trí đầu tiên của số 20 trong danh sách là: {timViTriDauTienCua20(lstNumber)}");

// Bài 7: Tìm số lượng phần tử bằng 15 trong danh sách
Func<List<int>, int> demPhanTuBang15 = (lst) =>
{
    int count = 0;
    foreach (int num in lst)
    {
        if (num == 15)
        {
            count++;
        }
    }
    return count;
};

Console.WriteLine($"Số lượng phần tử bằng 15 trong danh sách là: {demPhanTuBang15(lstNumber)}");

// Bài 8: Tính tổng các số nhỏ hơn 40
Func<List<int>, int> tinhTongPhanTuNhoHon40 = (lst) =>
{
    int sum = 0;
    foreach (int num in lst)
    {
        if (num < 40)
        {
            sum += num;
        }
    }
    return sum;
};

Console.WriteLine($"Tổng các số nhỏ hơn 40 trong danh sách là: {tinhTongPhanTuNhoHon40(lstNumber)}");

// Bài 9: Đếm số lượng các số chia hết cho 5
Func<List<int>, int> demPhanTuChiaHetCho5 = (lst) =>
{
    int count = 0;
    foreach (int num in lst)
    {
        if (num % 5 == 0)
        {
            count++;
        }
    }
    return count;
};

Console.WriteLine($"Số lượng các số chia hết cho 5 trong danh sách là: {demPhanTuChiaHetCho5(lstNumber)}");

// Bài 10: Tạo danh sách mới chỉ chứa các số nhỏ hơn 50
Func<List<int>, List<int>> taoDanhSachNhoHon50 = (lst) =>
{
    List<int> newList = new List<int>();
    foreach (int num in lst)
    {
        if (num < 50)
        {
            newList.Add(num);
        }
    }
    return newList;
};

var lstNhoHon50 = taoDanhSachNhoHon50(lstNumber);
Console.WriteLine("Các số nhỏ hơn 50 trong danh sách là:");
foreach (int num in lstNhoHon50)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

// Tìm vị trí lớn nhất trong danh sách
Func<List<int>, int> timViTriLonNhat = (lst) =>
{
    int max = lst[0];
    int index = 0;
    for (int i = 1; i < lst.Count; i++)
    {
        if (lst[i] > max)
        {
            max = lst[i];
            index = i;
        }
    }
    return index;
};

Console.WriteLine($"Vị trí của số lớn nhất trong danh sách là: {timViTriLonNhat(lstNumber)}");

// Lọc ra các số lớn hơn 50
Func<List<int>, List<int>> locSoLonHon50 = (lst) =>
{
    List<int> newList = new List<int>();
    foreach (int num in lst)
    {
        if (num > 50)
        {
            newList.Add(num);
        }
    }
    return newList;
};

Console.Write($"Các số lớn hơn 50 trong danh sách là: {JsonSerializer.Serialize(locSoLonHon50(lstNumber))}");
