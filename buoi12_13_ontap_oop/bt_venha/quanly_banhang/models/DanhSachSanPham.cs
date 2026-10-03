public class DanhSachSanPham
{
    private List<SanPham> danhSach;

    public DanhSachSanPham()
    {
        danhSach = new List<SanPham>();
    }

    public void ThemSanPham(List<SanPham> danhSach)
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        Console.Write("Lựa chọn của bạn: ");
        int choice = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập mã sản phẩm: ");
        string maSP = Console.ReadLine() ?? "";
        Console.Write("Nhập tên sản phẩm: ");
        string tenSP = Console.ReadLine() ?? "";
        Console.Write("Nhập giá bán: ");
        double giaBan = double.Parse(Console.ReadLine() ?? "0");

        SanPham sanPham = choice switch
        {
            1 => new DienTu(maSP, tenSP, giaBan, double.Parse(Console.ReadLine() ?? "0")), // Nhập thêm thông tin đặc trưng cho Điện tử
            2 => new ThoiTrang(maSP, tenSP, giaBan, double.Parse(Console.ReadLine() ?? "0")),
            3 => new ThucPham(maSP, tenSP, giaBan, double.Parse(Console.ReadLine() ?? "0")),
            _ => throw new ArgumentException("Lựa chọn không hợp lệ")
        };

        danhSach.Add(sanPham);
    }

    public void HienThiDanhSach(List<SanPham> danhSach)
    {
        foreach (SanPham sanPham in danhSach)
        {
            double gia = sanPham.TinhGiaBan(); 
            Console.WriteLine($"Mã: {sanPham.MaSanPham}, Tên: {sanPham.TenSanPham}, Giá bán: {gia} VND");
        }
    }

    public double TinhTongDoanhThu(List<SanPham> danhSach)
    {
        double tongDoanhThu = 0;
        foreach (SanPham sanPham in danhSach)
        {
            tongDoanhThu += sanPham.TinhGiaBan();
        }
        return tongDoanhThu;
    }

    public bool XoaSanPham(List<SanPham> danhSach, string maSP)
    {
        SanPham? sanPhamCanXoa = danhSach.FirstOrDefault(sp => sp.MaSanPham == maSP);
        if (sanPhamCanXoa != null)
        {
            danhSach.Remove(sanPhamCanXoa);
            Console.WriteLine($"Đã xóa sản phẩm có mã: {maSP}");
            return true;
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sản phẩm có mã: {maSP}");
            return false;
        }
    }
}