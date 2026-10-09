public class KhachHang
{
    public int Id { get; set; }
    public string TenKhachHang { get; set; } = "Khách hàng";
    public List<HoaDon> lstHoaDon { get; set; } = new List<HoaDon>();

    public KhachHang(string tenKhachHang = "Khách hàng")
    {
        TenKhachHang = tenKhachHang;
    }
}