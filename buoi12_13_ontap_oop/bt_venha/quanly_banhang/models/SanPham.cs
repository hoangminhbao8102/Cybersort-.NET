public abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }

    public SanPham(string maSP, string tenSP, double giaGoc)
    {
        MaSanPham = maSP;
        TenSanPham = tenSP;
        GiaGoc = giaGoc;
    }

    public abstract double TinhGiaBan();

    public virtual string HienThiThongTin()
    {
        return $"Mã SP: {MaSanPham}, Tên SP: {TenSanPham}, Giá gốc: {GiaGoc:C}";
    }
}