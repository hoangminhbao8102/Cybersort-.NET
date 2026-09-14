using System.Text.Json;

List<int> lstNumber = [2, 7, 5, 15];
List<int> prices = [1, 2, 5, 3, 6, 4];
List<int> lst_nums = [2, 2, 2, 7, 7, 7, 7, 9, 9];

// Two sum

Func<List<int>, int, List<int>> TimViTri2SoCoTong = (lst, target) => // lst = [2, 7, 5, 15] target = 9 => Output = [0, 1]
{
    // Output
    List<int> output = [];
    for (int i = 0; i < lst.Count - 1; i++)
    {
        for (int j = i + 1; j < lst.Count; j++)
        {
            if (lst[i] + lst[j] == target)
            {
                output = [i, j];
                return output;
            }
        }
    }
    return output;
};

Console.WriteLine($@"Two sum: {JsonSerializer.Serialize(TimViTri2SoCoTong(lstNumber, 9))}");

// List + dict
Func<List<int>, int, List<int>> TwoSum = (lst, target) =>
{
    List<int> lstOutput = new List<int>(); // a + b = target
    Dictionary<int, int> dict = new Dictionary<int, int>();
    // Dict => {valueA : indexA, valueB : indexB}
    for (int i = 0; i < lst.Count; i++)
    {
        int a = lst[i]; // 2
        int soCanTim = target - a; // 9
        if (dict.ContainsKey(soCanTim)) // Nếu dict có số 9 thì lấy value của dict
        {
            lstOutput.Add(dict[soCanTim]);
            lstOutput.Add(i);
            break;
        }
        // Nếu không có 9 thì đem giá trị lưu thành key của dict và vị trí = value của dict
        dict[a] = i;
    }
    return lstOutput;
};

Console.WriteLine($@"Kết quả của List + dict: {JsonSerializer.Serialize(TwoSum(lstNumber, 20))}");

// Best Time to Buy and Sell Stock
Func<List<int>, int> bestTimeToBuyAndSellStock = (lst) => // prices = [1, 2, 5, 3, 6, 4]
{
    int output = 0;

    for (int i = 1; i < lst.Count; i++)
    {
        int giaMua = lst[i];
        for (int j = i + 1; j < lst.Count; j++)
        {
            int giaBan = lst[j];
            if (giaBan - giaMua > output)
            {
                output = giaBan - giaMua;
            }
        }
    }

    return output;
};

Console.WriteLine($@"Lợi nhuận lớn nhất là: {bestTimeToBuyAndSellStock(prices)}");

Func<List<int>, int> loiNhuanLonNhat = (lst) =>
{
    int loiNhuanMax = 0;
    int giaMuaMin = 0;

    for (int i = 1; i < lst.Count; i++)
    {
        int giaBan = lst[i];

        int loiNhuan = giaBan - giaMuaMin;
        if (loiNhuan > loiNhuanMax)
        {
            loiNhuanMax = loiNhuan;
        }

        int giaMua = lst[i];
        if (giaMua < giaMuaMin)
        {
            giaMuaMin = giaMua;
        }
    }
    return loiNhuanMax;
};

Console.WriteLine($@"Lợi nhuận tối đa là: {loiNhuanLonNhat(prices)}");

/*
    Tìm tần suất xuất hiện của số n trong mảng
    Input: [2, 2, 2, 7, 7, 7, 7, 9, 9]
    => Output: [7, 3] => Số 7 xuất hiện 3 lần
*/

Func<List<int>, List<int>> timTanSuatXH = (lst) =>
{
    List<int> lstOutput = [];
    HashSet<int> setNumber = new HashSet<int>(lst); // Loại bỏ phần tử trùng nhau
    int soXH = lst[0]; // Số đầu tiên
    int demMax = 1; // Xuất hiện 1 lần
    foreach (var value in setNumber)
    {
        int so = value; // 2
        int dem = 0;
        for (int i = 0; i < lst.Count; i++)
        {
            if (so == lst[i])
            {
                dem++;
            }
        }
        if (dem > demMax)
        {
            soXH = value;
            demMax = dem;
        }
    }
    lstOutput.Add(soXH);
    lstOutput.Add(demMax);
    return lstOutput;
};

List<int> ketQuaTanSuat = timTanSuatXH(lst_nums);
Console.WriteLine($"Output: {JsonSerializer.Serialize(ketQuaTanSuat)} => Số {ketQuaTanSuat[0]} xuất hiện {ketQuaTanSuat[1]} lần");
