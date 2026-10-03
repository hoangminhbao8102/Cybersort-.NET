public abstract class SanPham
{
    public string MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double GiaGoc { get; set; }

    public SanPham(string ma, string ten, double giaGoc)
    {
        MaSanPham = ma;
        TenSanPham = ten;
        GiaGoc = giaGoc;
    }

    // Phương thức trừu tượng
    public abstract double TinhGiaBan();

    // Phương thức virtual
    public virtual void HienThiThongTin()
    {
        Console.WriteLine(
            $"Mã: {MaSanPham}, Tên: {TenSanPham}, Giá bán: {TinhGiaBan():0} VNĐ"
        );
    }
}