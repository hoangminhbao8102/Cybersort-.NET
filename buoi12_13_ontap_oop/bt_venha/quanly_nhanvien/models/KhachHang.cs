public class KhachHang : Nguoi
{
    public string MaKH { get; set; } = string.Empty;
    public int DiemTichLuy { get; set; } = 0;

    public KhachHang(string maKH, string hoTen, string soDienThoai, int namSinh, int diemTichLuy) : base(hoTen, soDienThoai, namSinh)
    {
        MaKH = maKH;
        DiemTichLuy = diemTichLuy;
    }

    public string MoTa()
    {
        return $"Mã KH: {MaKH}, Họ tên: {HoTen}, Điểm tích lũy: {DiemTichLuy}, Tuổi: {Tuoi()}";
    }
}