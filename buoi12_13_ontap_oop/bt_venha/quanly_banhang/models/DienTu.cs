public class DienTu : SanPham
{
    public double ThueBaoHanh { get; set; }

    public DienTu(string maSP, string tenSP, double giaGoc, double thueBH)
        : base(maSP, tenSP, giaGoc)
    {
        ThueBaoHanh = thueBH;
    }

    public override double TinhGiaBan()
    {
        return GiaGoc + (GiaGoc * ThueBaoHanh / 100); // Ví dụ: tính giá bán với thuế bảo hành
    }

    public override string HienThiThongTin()
    {
        return base.HienThiThongTin() + $", Thuế bảo hành: {ThueBaoHanh:P}";
    }
}