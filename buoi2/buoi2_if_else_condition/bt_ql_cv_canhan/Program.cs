using System.Text;

/*
Viết chương trình C# để thực hiện yêu cầu sau.
Yêu cầu: Bạn đang lập trình một tính năng nhỏ cho một ứng dụng quản lý công việc cá nhân. Khi người dùng nhập vào một số từ 1 đến 7, hệ thống sẽ hiển thị tên ngày trong tuần tương ứng để phục vụ sắp xếp lịch. 
Hãy viết chương trình C# cho phép người dùng: 
1.Nhập vào một số nguyên từ 1 đến 7. 
2.In ra tên ngày trong tuần tương ứng 
3.Nếu người dùng nhập số ngoài phạm vi 1–7, hiển thị thông báo: "Giá trị không hợp lệ. Vui lòng nhập số từ 1 đến 7."
*/
Console.OutputEncoding = Encoding.UTF8;
// input: nhập vào một số từ 1 đến 7
Console.Write("Nhập vào một số từ 1 đến 7: ");
int so = int.Parse(Console.ReadLine() ?? "0");
// output: in ra tên ngày trong tuần tương ứng hoặc thông báo lỗi
string tenNgay = "";
// process: kiểm tra điều kiện số nhập vào để xác định tên ngày trong tuần
tenNgay = so switch
{
    1 => "Thứ Hai",
    2 => "Thứ Ba",
    3 => "Thứ Tư",
    4 => "Thứ Năm",
    5 => "Thứ Sáu",
    6 => "Thứ Bảy",
    7 => "Chủ Nhật",
    _ => "Giá trị không hợp lệ. Vui lòng nhập số từ 1 đến 7."
};
// print result: in ra tên ngày trong tuần nếu hợp lệ
Console.WriteLine($"Tên ngày trong tuần: {tenNgay}");
