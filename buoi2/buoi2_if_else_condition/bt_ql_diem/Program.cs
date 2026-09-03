using System.Text;

/*
Viết chương trình C# để thực hiện yêu cầu sau.
Bài tập: Xây dựng chương trình quản lý điểm học sinh
Mô tả: Bạn cần xây dựng một chương trình nhận điểm số của học sinh và in ra xếp loại tương ứng dựa trên thang điểm chữ. Cụ thể: 
Điểm A: Từ 90 đến 100 
Điểm B: Từ 80 đến 89 
Điểm C: Từ 70 đến 79 
Điểm D: Từ 60 đến 69 
Điểm F: Dưới 60 
Yêu cầu: 
1.Chương trình sẽ nhận vào một điểm số từ 0 đến 100. 
2.Sử dụng switch...case để xác định xếp loại (A, B, C, D, F) dựa trên điểm số. 
3.In ra kết quả xếp loại của học sinh.
*/
Console.OutputEncoding = Encoding.UTF8;
// input: nhập vào điểm số từ 0 đến 100
Console.Write("Nhập vào điểm số từ 0 đến 100: ");
int diem = int.Parse(Console.ReadLine() ?? "0");
// output: in ra xếp loại tương ứng hoặc thông báo lỗi
string xepLoai = "";
// process: kiểm tra điều kiện điểm số nhập vào để xác định xếp loại
xepLoai = diem switch
{
    >= 90 and <= 100 => "A",
    >= 80 and < 90 => "B",
    >= 70 and < 80 => "C",
    >= 60 and < 70 => "D",
    >= 0 and < 60 => "F",
    _ => "Giá trị không hợp lệ. Vui lòng nhập điểm số từ 0 đến 100."
};
// print result: in ra xếp loại của học sinh
Console.WriteLine($"Xếp loại: {xepLoai}");
