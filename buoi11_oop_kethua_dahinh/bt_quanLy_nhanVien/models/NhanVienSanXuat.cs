public class NhanVienSanXuat : NhanVien
{
    public string danhMucHangHoa { get; set; } = "";

    // Override hàm tạo
    public NhanVienSanXuat(bool phatSinhMa = true) : base(phatSinhMa)
    {
        // Nhập 4 thông tin
        this.loaiNhanVien = 2;
        Console.Write("Nhập vào danh mục hàng hóa: ");
        this.danhMucHangHoa = Console.ReadLine() ?? "0";
    }

    public NhanVienSanXuat(int maNV, string tenNV, double luongCB, double soGL, int loaiNV) : base (maNV, tenNV, luongCB, soGL, loaiNV) { }

    public override double TinhLuong()
    {
        return base.TinhLuong() * 1.5;
    }
    public override void XuatThongTinNhanVien()
    {
        Console.WriteLine($"Nhân viên sản xuất:\nMã số: {this.maNhanVien}\nTên: {this.tenNhanVien}\nLương: {this.TinhLuong()}");
    }
}