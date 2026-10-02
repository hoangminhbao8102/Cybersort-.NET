public class NhanVienVanPhong : NhanVien
{
    public string danhSachHopDong { get; set; } = "";

    // Override khởi tạo
    public NhanVienVanPhong(bool phatSinhMa = true) : base(phatSinhMa)
    {
        // Nhập 4 thông tin
        this.loaiNhanVien = 3;
        Console.Write("Nhập vào danh sách hợp đồng: ");
        this.danhSachHopDong = Console.ReadLine() ?? "0";
    }

    public NhanVienVanPhong(int maNV, string tenNV, double luongCB, double soGL, int loaiNV) : base (maNV, tenNV, luongCB, soGL, loaiNV) { }

    public override double TinhLuong()
    {
        return base.TinhLuong() * 1;
    }
    public override void XuatThongTinNhanVien()
    {
        Console.WriteLine($"Nhân viên văn phòng:\nMã số: {this.maNhanVien}\nTên: {this.tenNhanVien}\nLương: {this.TinhLuong()}");
    }
}