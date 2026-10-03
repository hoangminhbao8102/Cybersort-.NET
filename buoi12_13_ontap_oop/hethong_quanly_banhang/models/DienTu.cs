public class DienTu : SanPham
{
    public double ThueBaoHanh { get; set; }

    public DienTu(
        string ma,
        string ten,
        double giaGoc,
        double thueBaoHanh
    ) : base(ma, ten, giaGoc)
    {
        ThueBaoHanh = thueBaoHanh;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + GiaGoc * ThueBaoHanh / 100;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
    }
}