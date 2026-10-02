// Class là kiểu dữ liệu mà chúng tự định nghĩa
public class NhanVien // Lớp đối tượng reference type (giống như collection)
{
    // private: chỉ gọi được trong phạm vi class
    // public: goi được trong class và cả đối tượng

    public string MaNhanVien { get; set; } = string.Empty;
    public string TenNhanVien { get; set; }
    public double LuongCoBan { get; set; }
    public double SoGioLam { get; set; }

    public NhanVien() // Constructor hàm khởi tạo - hàm tạo
    {
        Console.WriteLine("Nhập vào họ tên: ");
        TenNhanVien = Console.ReadLine() ?? "0";
        Console.WriteLine("Nhập vào mã nhân viên: ");
        TenNhanVien = Console.ReadLine() ?? "0";
        Console.WriteLine("Nhập vào lương cơ bản: ");
        LuongCoBan = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập vào số giờ làm: ");
        SoGioLam = Convert.ToDouble(Console.ReadLine());
    }

    private double TinhLuong()
    {
        return LuongCoBan * SoGioLam;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã nhân viên: {MaNhanVien}\n Tên nhân viên: {TenNhanVien}\n Tổng lương: {TinhLuong()}");
    }
}