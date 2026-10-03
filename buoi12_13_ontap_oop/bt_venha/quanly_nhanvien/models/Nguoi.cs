public class Nguoi
{

    public string HoTen { get; set; } = string.Empty;
    public string SoDienThoai { get; set; } = string.Empty;
    public int NamSinh { get; set; }
    
    public Nguoi(string hoTen, string soDienThoai, int namSinh)
    {
        HoTen = hoTen;
        SoDienThoai = soDienThoai;
        NamSinh = namSinh;
    }

    public int Tuoi()
    {
        return DateTime.Now.Year - NamSinh;
    }
}