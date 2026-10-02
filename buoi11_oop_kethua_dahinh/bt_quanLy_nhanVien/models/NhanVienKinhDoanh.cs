public class NhanVienKinhDoanh : NhanVien
{
    public string danhMucKhachHang { get; set; } = "";

    // Override hàm tạo
    public NhanVienKinhDoanh(bool phatSinhMa = true) : base(phatSinhMa)
    {
        // Nhập 4 thông tin
        this.loaiNhanVien = 1;
        Console.Write("Nhập vào danh mục khách hàng: ");
        this.danhMucKhachHang = Console.ReadLine() ?? "0";
    }

    public NhanVienKinhDoanh(int maNV, string tenNV, double luongCB, double soGL, int loaiNV) : base (maNV, tenNV, luongCB, soGL, loaiNV) { }

    public override double TinhLuong()
    {
        return base.TinhLuong() * 3;
    }
    public override void XuatThongTinNhanVien()
    {
        Console.WriteLine($"Nhân viên kinh doanh:\nMã số: {this.maNhanVien}\nTên: {this.tenNhanVien}\nLương: {this.TinhLuong()}");
    }
}