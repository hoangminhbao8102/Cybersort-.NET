public class ThucPham : SanPham
{
    public double PhiVanChuyen { get; set; }

    public ThucPham(string maSP, string tenSP, double giaGoc, double phiVC)
        : base(maSP, tenSP, giaGoc)
    {
        PhiVanChuyen = phiVC;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + PhiVanChuyen; // Ví dụ: tính giá bán với phí vận chuyển
    }

    public override string HienThiThongTin()
    {
        return base.HienThiThongTin() + $", Phí vận chuyển: {PhiVanChuyen:C}";
    }
}