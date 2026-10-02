public class NhanVien
{
    public static int stt = 1;
    public int maNhanVien { get; set; }
    public string tenNhanVien { get; set; } = string.Empty;
    public double luongCoBan { get; set; }
    public double soGioLam { get; set; }
    public int loaiNhanVien { get; set; }

    public NhanVien() { }

    public NhanVien(int maNV, string tenNV, double luongCB, double soGL, int loaiNV)
    {
        this.maNhanVien = maNV;
        this.tenNhanVien = tenNV;
        this.luongCoBan = luongCB;
        this.soGioLam = soGioLam;
        this.loaiNhanVien = loaiNV;
    }

    public NhanVien(bool phatSinhMa)
    {
        this.maNhanVien = stt;
        NhanVien.stt++;

        Console.Write("Nhập vào họ tên nhân viên: ");
        this.tenNhanVien = Console.ReadLine() ?? "0";
        Console.Write("Nhập vào lương cơ bản: ");
        this.luongCoBan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào số giờ làm: ");
        this.soGioLam = Convert.ToDouble(Console.ReadLine());
    }

    public virtual double TinhLuong()
    {
        return luongCoBan * soGioLam;
    }

    public virtual void XuatThongTinNhanVien()
    {
        
    }
}