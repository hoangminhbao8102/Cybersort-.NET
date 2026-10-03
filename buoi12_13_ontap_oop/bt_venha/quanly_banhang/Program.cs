DanhSachSanPham danhSachSanPham = new DanhSachSanPham();
List<SanPham> danhSach = new List<SanPham>();
bool dangChay = true;

while (dangChay)
{
    Console.WriteLine();
    Console.WriteLine("===== HỆ THỐNG QUẢN LÝ BÁN HÀNG =====");
    Console.WriteLine("1. Thêm sản phẩm");
    Console.WriteLine("2. Hiển thị danh sách sản phẩm");
    Console.WriteLine("3. Tính tổng doanh thu của cửa hàng");
    Console.WriteLine("4. Xóa sản phẩm theo mã");
    Console.WriteLine("0. Thoát");
    Console.WriteLine("=============================");
    Console.Write("Chọn chức năng: ");
    string? input = Console.ReadLine()?.Trim();
    if (input == "5")
    {
        break; // Thoát vòng lặp nếu người dùng nhập "5"
    }
    try
    {
        switch (input)
        {
            case "1":
                danhSachSanPham.ThemSanPham(danhSach);
                break;
            case "2":
                danhSach.Add(new DienTu("1", "Laptop asus", 1000, 8));
                danhSach.Add(new ThoiTrang("2", "áo thun trắng", 200, 3));
                danhSach.Add(new ThucPham("3", "gạo trắng", 300, 10));
                foreach (SanPham sp in danhSach)
                {
                    double gia = sp.TinhGiaBan();
                    Console.WriteLine($"Mã: {sp.MaSanPham}, Tên: {sp.TenSanPham}, Giá bán: {gia} VND");
                }
                break;
            case "3":
                Console.WriteLine($"Tổng doanh thu của cửa hàng: {danhSachSanPham.TinhTongDoanhThu(danhSach)} VNĐ");
                break;
            case "4":
                Console.Write("Mã SP cần xóa: ");
                var maSPXoa = Console.ReadLine()?.Trim() ?? "";
                Console.WriteLine(danhSachSanPham.XoaSanPham(danhSach, maSPXoa) ? "Xóa thành công." : "Không tìm thấy sản phẩm để xóa.");
                break;
            case "0":
                dangChay = false;
                Console.WriteLine("Đã thoát chương trình.");
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                break;
        }
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Nhập sai định dạng số: {ex.Message}. Vui lòng nhập lại.");
    }
}