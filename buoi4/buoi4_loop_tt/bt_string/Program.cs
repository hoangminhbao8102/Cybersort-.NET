using System.Net.Http.Headers;

string title = "MinhBao";
// index        0123456
/*
Vị trí của char
char cl = title[0];
*/

Console.WriteLine($"{title[0]}");
Console.WriteLine($"{title[6]}");
/*
.Container("chuoi_con"): Kiểm tra chuỗi con có trong chuỗi lớn hay không nếu có trả về true nếu không trả về false.
Lưu ý phân biệt hoa thường
*/

bool kq1 = title.Contains("Bao");
Console.WriteLine($"{kq1}");

/*
.StartsWith("chuoi_con"): Kiểm tra chuỗi lớn có bắt đầu bằng chuỗi con hay không nếu có in ra true nếu không in ra false.
*/

bool kq2 = title.StartsWith("Minh");
Console.WriteLine($".StartsWith {kq2}");


/*
.EndsWith("chuoi_con"): Kiểm tra chuỗi lớn có kết thúc bằng chuỗi con hay không nếu có in ra true nếu không in ra false.
*/

bool kq3 = title.EndsWith("Bao");
Console.WriteLine($".EndsWith {kq3}");

/*
IndexOf (đẩu tiên) hoặc LastIndexOf (cuối cùng)
Tìm ra vị trí đầu tiên hoặc cuối cùng của chuỗi con trong chuỗi lớn nếu có xuất hiện ít nhất 1 lần.
Nếu không có xuất hiện chuỗi con trong chuỗi lớn thì trả về -1
*/

Console.WriteLine($"{title.IndexOf("of")}");
Console.WriteLine($"{title.LastIndexOf("of")}");
Console.WriteLine($"{title.IndexOf("ABC")}");

/*
    .SubString(vi_tri_bat_dau, soLuongKyTu): Dùng để cắt chuỗi con từ chuỗi lớn
    Lưu ý: Khoảng trắng là 1 ký tự
*/

// Chuỗi moTa có dùng 500 ký tự (moTa.Length == 500)
string moTa = ".NET (hay DotNet) là một nền tảng phát triển phần mềm miễn phí, mã nguồn mở do Microsoft tạo ra. Nền tảng này giúp lập trình viên xây dựng nhiều loại ứng dụng khác nhau.";

Console.WriteLine($"{moTa.Substring(0, 5)}");

// .Length: Số lượng ký tự của chuỗi (độ dài của chuỗi)
Console.WriteLine($".Length {moTa.Length}");

string bankCode = "1234 5678 9012 3456";

for (int i = 0; i < bankCode.Length; i++)
{
    if (bankCode[i] == ' ')
    {
        Console.Write("\n");
    }
    else
    {
        Console.Write($"{bankCode[i]}");
    }
}

Console.WriteLine("============");
// .Join(ky_tu): Chèn vào mỗi phẩn tử trong collection ký tự tương ứng
string[] arr = new string[] {"C", "y", "b", "e", "r", "S", "o", "f", "t"};
Console.WriteLine($".Join : {string.Join(" - ", arr)}");

/*
    .Remove(vi_tri,so_luong): Xóa char tại vị trí tương ứng với số lượng tương ứng, nếu không truyền số lượng thì xóa từ vị trí đó đến hết chuỗi
*/
string name = ".Net08";
Console.WriteLine($"{name.Remove(3)}");

// Replace("kytu", "kyTuChuyenDoi"): TRhay thế ký tự bằng ký tự chuyển đổi

string nameTitle = "Hoàng Nghĩa Minh Bảo";
Console.WriteLine($"{nameTitle.Replace(" ", "-")}");

/* 
    IsNullOrEmpty(): Kiểm tra chỗi đó có null hoặc " " hay không
    IsNullOrWhiteSpace(): Tính cả trường hợp " " vẫn trả về true
*/

string ex1 = "";
string ex2 = "abc"; // Lưu ý: " " vẫn là có ký tự
string ex3 = null!;

Console.WriteLine($"ex1 : {string.IsNullOrEmpty(ex1)}");
Console.WriteLine($"ex2 : {string.IsNullOrWhiteSpace(ex2)}");
Console.WriteLine($"ex3 : {string.IsNullOrEmpty(ex3)}");

/*
    string name = "abc";
    hello abc => @$"hello {name}" // Cách mới
    string.Format("hello {0}", name) // Cách cũ
*/

Console.WriteLine(string.Format($"Hello {name}, title {title}"));

/*
    .Compare("chuoi1","chuoi2")
    Bằng số lượng khác ký tự: 0
    Khác số lượng khác ký tự: -1
    Giống nhau về số lượng và ký tự: 1
*/
string a = "abcd";
string b = "abcd1234";

Console.WriteLine($"{a == b}");
Console.WriteLine($"{string.Compare(a, b)}");

Console.WriteLine($"{a.PadLeft(10)}");
Console.WriteLine($"{a.PadRight(10)}");

string hoTen = "Nguyễn Văn A";
Console.WriteLine($"{string.Join("-", hoTen.ToCharArray())}");
