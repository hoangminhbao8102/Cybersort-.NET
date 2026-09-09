using System.Text.Json;

// Primitive Types: string, int, double, bool, ... máy tính có thể hiểu trực tiếp được
/*
    reference type: class, interface, delegate, array, ... máy tính không thể hiểu trực tiếp được
*/

/*
    Khai báo List<T> là một collection (tập hợp) có thể chứa nhiều phần tử cùng kiểu dữ liệu T 
    Cú pháp khai báo: List<T> <tên biến> = new List<T>();
*/

List<int> dsDiemTB = new List<int>() { 5, 6, 7, 8, 9, 10 };

/*
    CURD: Create, Update, Read (Search), Delete
    - Create: thêm phần tử vào collection
    - Update: cập nhật giá trị của phần tử trong collection
    - Read (Search): tìm kiếm phần tử trong collection
    - Delete: xóa phần tử khỏi collection
*/

// Read (Search): tìm kiếm phần tử trong collection
// lst[index] => truy xuất phần tử trong collection theo index (vị trí của phần tử trong collection)
// Console.WriteLine($"{dsDiemTB[2]}"); // truy xuất phần tử thứ 2 trong collection dsDiemTB

/*
    Duyệt list bằng vòng lặp for hoặc foreach
*/
// Duyệt list bằng vòng lặp for
for (int i = 0; i < dsDiemTB.Count; i++)
{
    Console.WriteLine($"{dsDiemTB[i]}");
}
// Duyệt list bằng vòng lặp foreach
Action DuyetList = () =>
{
    foreach (int diemTB in dsDiemTB)
    {
        Console.WriteLine($"Duyệt bằng foreach: {diemTB}");
    }
};

// Create: thêm phần tử vào collection
/* 
    Cú pháp:
    - <tên collection>.Add(<giá trị cần thêm>); (Mức độ thường dùng): Thêm phần tử vào cuối collection
    - <tên collection>.Insert(<index>, <giá trị cần thêm>); (Mức độ ít dùng): Thêm phần tử vào vị trí index trong collection
    - <tên collection>.AddRange(<collection cần thêm>); (Mức độ ít dùng): Thêm nhiều phần tử từ một collection khác vào collection hiện tại
*/
dsDiemTB.Add(11); // thêm phần tử 11 vào collection dsDiemTB
dsDiemTB.Insert(0, 4); // thêm phần tử 4 vào vị trí 0 trong collection dsDiemTB
dsDiemTB.AddRange(new List<int>() { 12, 13, 14 }); // thêm nhiều phần tử từ một collection khác vào collection dsDiemTB
// Gọi hàm DuyetList để duyệt list dsDiemTB
DuyetList();

Console.WriteLine($"{dsDiemTB}"); // in ra địa chỉ của collection dsDiemTB

/*
    Muốn xem giá trị của list trong màn hình console thì có thể dùng JsonSerializer.Serialize(<tên collection>) để chuyển đổi list thành chuỗi JSON và in ra màn hình console
*/
Console.WriteLine(JsonSerializer.Serialize(dsDiemTB));

/*
    Update: cập nhật giá trị của phần tử trong collection
    Cú pháp: <tên collection>[<index>] = <giá trị mới>;
*/
dsDiemTB[0] = 3; // cập nhật giá trị của phần tử tại vị trí 0 trong collection dsDiemTB thành 3
// Gọi hàm DuyetList để duyệt list dsDiemTB
DuyetList();

// Thay đổi giá trị 14 thành 15 trong collection dsDiemTB
int index = dsDiemTB.IndexOf(14); // tìm vị trí của phần tử 14 trong collection dsDiemTB
if (index != -1) // nếu tìm thấy phần tử 14 trong collection dsDiemTB thì cập nhật giá trị của phần tử tại vị trí index thành 15
{
    dsDiemTB[index] = 15;
}
// Hoặc
int indexFind = -1;
for (int i = 0; i < dsDiemTB.Count; i++)
{
    if (dsDiemTB[i] == 14)
    {
        indexFind = i;
        break;
    }
}
if (indexFind != -1)
{
    dsDiemTB[indexFind] = 15;
}

Console.WriteLine(JsonSerializer.Serialize(dsDiemTB)); // in ra giá trị của collection dsDiemTB sau khi cập nhật giá trị 14 thành 15

/*
    Delete: xóa phần tử khỏi collection
    Cú pháp:
    - <tên collection>.Remove(<giá trị cần xóa>); (Mức độ thường dùng): Xóa phần tử có giá trị bằng <giá trị cần xóa> khỏi collection
    - <tên collection>.RemoveAt(<index>); (Mức độ ít dùng): Xóa phần tử tại vị trí index khỏi collection
    - <tên collection>.Clear(); (Mức độ ít dùng): Xóa tất cả phần tử khỏi collection
    - <tên collection> = null; (Mức độ ít dùng): Xóa tất cả phần tử khỏi collection và giải phóng bộ nhớ
*/

// Xóa phần tử có giá trị bằng 15 khỏi collection dsDiemTB
dsDiemTB.Remove(15); // xóa phần tử có giá trị bằng 15
// Hoặc
int indexDel = -1;
for (int i = 0; i < dsDiemTB.Count; i++)
{
    if (dsDiemTB[i] == 15)
    {
        indexDel = i;
        break;
    }
}
if (indexDel != -1)
{
    dsDiemTB.RemoveAt(indexDel);
}

Console.WriteLine(JsonSerializer.Serialize(dsDiemTB)); // in ra giá trị của collection dsDiemTB sau khi xóa phần tử 15

// .Sort(): sắp xếp các phần tử trong collection theo thứ tự tăng dần
dsDiemTB.Sort();
Console.WriteLine(JsonSerializer.Serialize(dsDiemTB)); // in ra giá trị của collection dsDiemTB sau khi sắp xếp các phần tử theo thứ tự tăng dần

// .Reverse(): sắp xếp các phần tử trong collection theo thứ tự giảm dần
dsDiemTB.Reverse();
Console.WriteLine(JsonSerializer.Serialize(dsDiemTB)); // in ra giá trị của collection dsDiemTB sau khi sắp xếp các phần tử theo thứ tự giảm dần

/*
    Array và List: Điểm giống và khác nhau
    - Điểm giống nhau: đều là collection (tập hợp) có thể chứa nhiều phần tử cùng kiểu dữ liệu
    - Điểm khác nhau:
        + Array: có kích thước cố định, không thể thay đổi kích thước sau khi khai báo, không có các phương thức hỗ trợ thao tác với collection
        + List: có kích thước động, có thể thay đổi kích thước sau khi khai báo, có các phương thức hỗ trợ thao tác với collection
*/

int [] arrDiemTB = new int[6] { 5, 6, 7, 8, 9, 10 }; // khai báo mảng arrDiemTB có kích thước cố định là 6 phần tử

Console.WriteLine(JsonSerializer.Serialize(arrDiemTB)); // in ra giá trị của mảng arrDiemTB

// .Find(): tìm kiếm phần tử trong collection theo điều kiện
int diemTB = dsDiemTB.Find(x => x > 8); // tìm kiếm phần tử đầu tiên trong collection dsDiemTB có giá trị lớn hơn 8
Console.WriteLine($"Phần tử đầu tiên trong collection dsDiemTB có giá trị lớn hơn 8 là: {diemTB}");

// .FindIndex(): tìm kiếm vị trí của phần tử trong collection theo điều kiện
int indexDiemTB = dsDiemTB.FindIndex(x => x > 8); // tìm kiếm vị trí của phần tử đầu tiên trong collection dsDiemTB có giá trị lớn hơn 8
Console.WriteLine($"Vị trí của phần tử đầu tiên trong collection dsDiemTB có giá trị lớn hơn 8 là: {indexDiemTB}");

// Lấy nhiều phần tử thỏa điều kiện
/*
    lstDTB = { 8.8, 7.3, 4.5, 6.5, 7.5 }
    Lấy ra tất cả điểm trung bình lớn hơn 7.0 trong lstDTB
    Input: lstDTB = { 8.8, 7.3, 4.5, 6.5, 7.5 }
    Output: lstDTB = { 8.8, 7.3, 7.5 }
*/

List<double> lstDTB = new List<double> { 8.8, 7.3, 4.5, 6.5, 7.5 };
List<double> lstDTBFiltered = lstDTB.FindAll(x => x > 7.0);
Console.WriteLine($"Các phần tử trong collection lstDTB có giá trị lớn hơn 7.0 là: {JsonSerializer.Serialize(lstDTBFiltered)}");

// Bài tập thực hành về List

List<int> lstNumber = [20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20];

/*
    Tính tổng các số lớn hơn 50 trong danh sách
    Yêu cầu: Viết chương trình tính tổng các số trong lstNumber mà lớn hơn 50.
*/

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


// Dictionary 
Dictionary<string, string> prod = new Dictionary<string, string>();
prod["id"] = "01";
prod["name"] = "Iphone";
prod["price"] = "1000";

Console.WriteLine($@"Dict Product: {JsonSerializer.Serialize(prod)}");


List<object> listOb = new List<object> {"01", "Iphone", 1000};

Dictionary<string, object> dictProd = new Dictionary<string, object>();
dictProd["id"] = "01";
dictProd["name"] = "Iphone";
dictProd["price"] = 1000;

Console.WriteLine($@"id: {dictProd["id"]} name: {dictProd["name"]} price:{dictProd["price"]}");

foreach (KeyValuePair<string, object> item in dictProd)
{
    Console.WriteLine($@"Key: {item.Key} - Value: {item.Value}");
}

// Tìm kiếm dựa trên key không cần chạy vòng lặp
if (dictProd.ContainsKey("id"))
{
    Console.WriteLine($@"id{dictProd["id"]}");    
}

// Xóa remove dựa vào key

dictProd.Remove("desc");

Console.WriteLine($@"Sau khi xóa key desc: {JsonSerializer.Serialize(dictProd)}");

/*
    Hashset là một dạng collection type lưu được nhiều giá trị tuy nhiên các giá trị sẽ không trùng
    Lưu ý: Giống list nhưng có index (Không duyệt theo vòng lặp for int được)
*/
HashSet<int> setInt = new HashSet<int>();
setInt.Add(1);
setInt.Add(2);
setInt.Add(3);
setInt.Add(4);
setInt.Add(5);

Console.WriteLine($@"{JsonSerializer.Serialize(setInt)}");
// Read
foreach (int value in setInt)
{
    Console.WriteLine($@"Set value: {value}");
}

// Update: Không update mà sẽ là remove sau đó add
HashSet<object> setProd = new HashSet<object>();
setProd.Add("01");
setProd.Add("Iphone");
setProd.Add(1000);

if (setProd.Contains("Iphone"))
{
    setProd.Remove("Iphone");
    setProd.Add("Iphone 17");
}

Console.WriteLine($@"Set prod: {JsonSerializer.Serialize(setProd)}");

// Set ít dùng trong việc lưu trữ mà chủ yếu để convert từ list song loại bỏ các giá trị trùng.

/* 
    object và dynamic
    - object: Khi khai báo sẽ chứa được tất cả kiểu dữ liệu khác nhưng khi sử dụng operation (+, -, *, /, ...) thì buộc phải tường minh nó
*/
object ob1 = 1;
object ob2 = 2;

// Khi thực hiện operation đối với object thì sẽ báo lỗi
object ob3 = (int)ob1 + (int)ob2;

dynamic dy1 = 1;
dynamic dy2 = 2;

dynamic dy3 = dy1 + dy2;

Console.WriteLine($@"dỷ: {dy3}");

dynamic dyProd = new
{
    id = 1,
    name = "Iphone",
    price = 1000,
};

object obProd = new
{
    id = 1,
    name = "Iphone",
    price = 1000,
};

var vProd = new
{
    id = 1,
    name = "Iphone",
    price = 1000,
};

Console.WriteLine($@"id: {dyProd.id} name: {dyProd.name} price: {dyProd.price}");
Console.WriteLine($@"id: {vProd.id} name: {vProd.name} price: {vProd.price}");
