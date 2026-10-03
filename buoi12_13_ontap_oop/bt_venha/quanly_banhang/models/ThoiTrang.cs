public class ThoiTrang : SanPham
{
    public double GiamGia { get; set; }

    public ThoiTrang(string maSP, string tenSP, double giaGoc, double giamGia)
        : base(maSP, tenSP, giaGoc)
    {
        GiamGia = giamGia;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc - (GiaGoc * GiamGia / 100); // Ví dụ: tính giá bán với mức giảm giá
    }

    public override string HienThiThongTin()
    {
        return base.HienThiThongTin() + $", Giảm giá: {GiamGia:P}";
    }
}