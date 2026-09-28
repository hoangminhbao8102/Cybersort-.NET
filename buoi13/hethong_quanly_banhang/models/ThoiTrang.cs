public class ThoiTrang : SanPham
{
    public double GiamGiaMua { get; set; }

    public ThoiTrang(
        string ma,
        string ten,
        double giaGoc,
        double giamGiaMua
    ) : base(ma, ten, giaGoc)
    {
        GiamGiaMua = giamGiaMua;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc - GiaGoc * GiamGiaMua / 100;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
    }
}