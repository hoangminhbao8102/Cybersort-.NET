public class ThucPham : SanPham
{
    public double PhiVanChuyen { get; set; }

    public ThucPham(
        string ma,
        string ten,
        double giaGoc,
        double phiVanChuyen
    ) : base(ma, ten, giaGoc)
    {
        PhiVanChuyen = phiVanChuyen;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + GiaGoc * PhiVanChuyen / 100;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
    }
}