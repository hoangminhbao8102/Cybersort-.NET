using System.Text;

/*
Viết chương trình C# để thực hiện cho phép người dùng nhập vào điểm toán, văn. Yêu cầu tính điểm trung bình và xếp loại học lực.
Ví dụ: Nếu điểm toán = 9.0 và điểm văn = 7.0 thì điểm trung bình = (9.0 + 7.0) / 2 = 8.0
Nếu điểm trung bình >= 9.0 và <= 10.0 thì in ra "Xếp loại xuất sắc"
Nếu điểm trung bình >= 8.0 và < 9.0 thì in ra "Xếp loại giỏi"
Nếu điểm trung bình >= 6.5 và < 8.0 thì in ra "Xếp loại khá"
Nếu điểm trung bình >= 5.0 và < 6.5 thì in ra "Xếp loại trung bình"
Nếu điểm trung bình < 5.0 thì in ra "Xếp loại yếu"
*/
Console.OutputEncoding = Encoding.UTF8;
// input: điểm toán và điểm văn
Console.Write("Nhập vào điểm toán: ");
double diemToan = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập vào điểm văn: ");
double diemVan = double.Parse(Console.ReadLine() ?? "0");
// output: điểm trung bình và xếp loại học lực
double dtb = (diemToan + diemVan) / 2;
string xepLoai = "";
// process: kiểm tra điều kiện điểm trung bình để xếp loại học lực
// Cách 1: Sử dụng nhiều câu lệnh if else
/*
if (dtb >= 9.0 && dtb <= 10.0)
{
    xepLoai = "Xuất sắc";
}
else if (dtb >= 8.0 && dtb < 9.0)
{
    xepLoai = "Giỏi";
}
else if (dtb >= 6.5 && dtb < 8.0)
{
    xepLoai = "Khá";
}
else if (dtb >= 5.0 && dtb < 6.5)
{
    xepLoai = "Trung bình";
}
else if (dtb < 5.0)
{
    xepLoai = "Yếu";
}
else
{
    xepLoai = "Điểm không hợp lệ";
}
*/
// Cách 2: Sử dụng switch case (C# 8.0 trở lên)
// Cách 2.1:
/*
switch (dtb)
{
    case double d when d >= 9.0 && d <= 10.0:
        xepLoai = "Xuất sắc";
        break;
    case double d when d >= 8.0 && d < 9.0:
        xepLoai = "Giỏi";
        break;
    case double d when d >= 6.5 && d < 8.0:
        xepLoai = "Khá";
        break;
    case double d when d >= 5.0 && d < 6.5:
        xepLoai = "Trung bình";
        break;
    case double d when d < 5.0:
        xepLoai = "Yếu";
        break;
    default:
        xepLoai = "Điểm không hợp lệ";
        break;
}
*/
// Cách 2.2:
xepLoai = dtb switch
{
    < 5.0 => "Yếu",
    >= 5.0 and < 6.5 => "Trung bình",
    >= 6.5 and < 8.0 => "Khá",
    >= 8.0 and < 9.0 => "Giỏi",
    >= 9.0 and <= 10.0 => "Xuất sắc",
    _ => "Điểm không hợp lệ"
};
// print result: in ra xếp loại học lực
Console.WriteLine($"Điểm trung bình: {dtb:F1}");
Console.WriteLine($"Xếp loại: {xepLoai}");

// Lưu ý: Một điều kiện có nhiều trường hợp.
