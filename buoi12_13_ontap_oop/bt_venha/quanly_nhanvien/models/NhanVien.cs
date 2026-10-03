public class NhanVien : Nguoi
{
    public string MaNV { get; set; } = string.Empty;
    public string ChucVu { get; set; } = string.Empty;
    private decimal _luongThang;

    public decimal LuongThang
    {
        get => _luongThang;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Lương tháng không được âm.");
            }

            _luongThang = value;
        }
    }

    public NhanVien(string maNV, string hoTen, string soDienThoai, int namSinh, string chucVu, decimal luongThang) : base(hoTen, soDienThoai, namSinh)
    {
        MaNV = maNV;
        ChucVu = chucVu;
        LuongThang = luongThang;
    }

    public decimal TienLuong()
    {
        return LuongThang;
    }

    public string MoTa()
    {
        return $"Mã NV: {MaNV}, Họ tên: {HoTen}, Chức vụ: {ChucVu}, Lương: {LuongThang:C}, Tuổi: {Tuoi()}";
    }
}