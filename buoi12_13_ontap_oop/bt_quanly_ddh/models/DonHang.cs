using System.Text;

public class DonHang
{
    public static int MaDonTuDong = 1;
    public int maDonHang { get; set; }
    // public int maDonHang { get; set; }
    public string tenKhach { get; set; } = string.Empty;
    public string diaChi { get; set; } = string.Empty;
    public double tienHang { get; set; }
    public int soKM { get; set; } // trên 10km + 5, trên 20 thì + 20

    public DonHang()
    {

    }

    public void nhapThongTinDonHang()
    {
        this.maDonHang = MaDonTuDong;
        DonHang.MaDonTuDong++;
        Console.Write("Nhập vào tên khách hàng: ");
        this.tenKhach = Console.ReadLine() ?? "0";
        Console.Write("Nhập vào địa chỉ giao: ");
        this.diaChi = Console.ReadLine() ?? "0";
        Console.Write("Nhập vào tiền hàng: ");
        this.tienHang = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào số km giao: ");
        this.soKM = Convert.ToInt32(Console.ReadLine());
    }

    public virtual double tinhPhiGiaoHang()
    {
        double phiGiao = 30;
        if (soKM > 10)
        {
            phiGiao += 5;
        }
        else if (soKM > 20)
        {
            phiGiao += 20;
        }
        return phiGiao;
    }

    public double tongThanhToanDonHang()
    {
        return this.tinhPhiGiaoHang() + tienHang;
    }

    public virtual string moTaDonHang()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        string moTa = $"Mã đơn: {this.maDonHang}\nTên khách: {this.tenKhach}\nĐịa chỉ: {this.diaChi}\nPhí giao hàng: {this.tinhPhiGiaoHang()}\nTổng tiền: {this.tongThanhToanDonHang()}";
        return moTa;
    }
}