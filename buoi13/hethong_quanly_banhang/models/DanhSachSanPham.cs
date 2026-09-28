public class DanhSachSanPham
{
    // Danh sách sản phẩm
    public List<SanPham> danhSach = new List<SanPham>();

    // Hiển thị menu
    public void HienThiMenu()
    {
        Console.WriteLine("\n--- Hệ thống quản lý bán hàng ---");
        Console.WriteLine("1. Thêm sản phẩm");
        Console.WriteLine("2. Hiển thị danh sách sản phẩm");
        Console.WriteLine("3. Tính tổng doanh thu");
        Console.WriteLine("4. Xóa sản phẩm");
        Console.WriteLine("5. Thoát");
    }

    // Thêm sản phẩm
    public void ThemSanPham()
    {
        Console.WriteLine("\nChọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");

        Console.Write("Lựa chọn: ");
        int loai = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhập mã sản phẩm: ");
        string ma = Console.ReadLine() ?? "0";

        Console.Write("Nhập tên sản phẩm: ");
        string ten = Console.ReadLine() ?? "0";

        Console.Write("Nhập giá gốc: ");
        double giaGoc = double.Parse(Console.ReadLine() ?? "0");

        switch (loai)
        {
            case 1:
                Console.Write("Nhập thuế bảo hành (%): ");
                double thue = double.Parse(Console.ReadLine() ?? "0");

                danhSach.Add(
                    new DienTu(ma, ten, giaGoc, thue)
                );
                break;

            case 2:
                Console.Write("Nhập giảm giá (%): ");
                double giamGia = double.Parse(Console.ReadLine() ?? "0");

                danhSach.Add(
                    new ThoiTrang(ma, ten, giaGoc, giamGia)
                );
                break;

            case 3:
                Console.Write("Nhập phí vận chuyển (%): ");
                double phiVanChuyen = double.Parse(Console.ReadLine() ?? "0");

                danhSach.Add(
                    new ThucPham(ma, ten, giaGoc, phiVanChuyen)
                );
                break;

            default:
                Console.WriteLine("Loại sản phẩm không hợp lệ!");
                break;
        }
    }

    // Hiển thị danh sách
    public void HienThiDanhSach()
    {
        Console.WriteLine("\nDanh sách sản phẩm:");

        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách đang trống!");
            return;
        }

        foreach (SanPham sp in danhSach)
        {
            sp.HienThiThongTin();
        }
    }

    // Tính tổng doanh thu
    public void TinhTongDoanhThu()
    {
        double tongDoanhThu = 0;

        foreach (SanPham sp in danhSach)
        {
            tongDoanhThu += sp.TinhGiaBan();
        }

        Console.WriteLine(
            $"\nTổng doanh thu dự kiến: {tongDoanhThu:0} VNĐ"
        );
    }

    // Xóa sản phẩm theo mã
    public void XoaSanPham()
    {
        Console.Write("Nhập mã sản phẩm cần xóa: ");
        string ma = Console.ReadLine() ?? "0";

        SanPham sanPhamCanXoa = null!;

        foreach (SanPham sp in danhSach)
        {
            if (sp.MaSanPham.Equals(
                ma,
                StringComparison.OrdinalIgnoreCase))
            {
                sanPhamCanXoa = sp;
                break;
            }
        }

        if (sanPhamCanXoa != null)
        {
            danhSach.Remove(sanPhamCanXoa);
            Console.WriteLine("Xóa sản phẩm thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm!");
        }
    }
}