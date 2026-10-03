using System.Text;

public class DonHangGiaoNhanh : DonHang
{
    public override double tinhPhiGiaoHang()
    {
        double phiGiaoNhanh = base.tinhPhiGiaoHang() + 60;
        return phiGiaoNhanh;
    }

    public override string moTaDonHang()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        string moTa = $"----- Đơn giao nhanh -----\nMã đơn: {this.maDonHang}\nTên khách: {this.tenKhach}\nĐịa chỉ: {this.diaChi}\nPhí giao hàng: {this.tinhPhiGiaoHang()}\nTổng tiền: {this.tongThanhToanDonHang()}";
        return moTa;
    }
}