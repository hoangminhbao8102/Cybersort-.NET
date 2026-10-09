public class HoaDon
{
    public string DichVu { get; set; } = string.Empty;
    public int SoLuong { get; set; }
    public double DonGia { get; set; }
}

public class HoaDonService
{
    public KhachHang ThongTinKhachHang { get; set; }

    public HoaDonService(KhachHang kh)
    {
        ThongTinKhachHang = kh;
    }

    public void TinhTongTienHoaDon()
    {
        Console.WriteLine($"Tổng tiền hóa đơn: \nKhách: {ThongTinKhachHang.TenKhachHang} \nTổng tiền: {ThongTinKhachHang.lstHoaDon.Sum(hd => hd.SoLuong * hd.DonGia)}");
    }
}