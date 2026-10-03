DanhSachNhanVien danhSachNhanVien = new DanhSachNhanVien();
bool dangChay = true;

while (dangChay)
{
    Console.WriteLine();
    Console.WriteLine("===== QUẢN LÝ NHÂN VIÊN =====");
    Console.WriteLine("1. Thêm nhân viên, từ chối nếu trùng mã");
    Console.WriteLine("2. Xoá theo mã");
    Console.WriteLine("3. Tìm theo mã hoặc theo chức vụ, không phân biệt hoa thường");
    Console.WriteLine("4. Hiển thị danh sách gồm mã, họ tên, tuổi, chức vụ, lương, thưởng và tổng lương tháng của cửa hàng");
    Console.WriteLine("0. Thoát");
    Console.WriteLine("=============================");
    Console.Write("Chọn chức năng: ");

    switch (Console.ReadLine()?.Trim())
    {
        case "1":
            Console.Write("Mã NV: ");
            var maNV = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Họ tên: ");
            var hoTen = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Chức vụ: ");
            var chucVu = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Số năm kinh nghiệm: ");
            int.TryParse(Console.ReadLine(), out var soNamKinhNghiem);

            Console.Write("Phòng ban: ");
            var phongBan = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Lương cơ bản: ");
            decimal.TryParse(Console.ReadLine(), out var luongCoBan);

            var nhanVien = new NhanVien(maNV, hoTen, chucVu, soNamKinhNghiem, phongBan, luongCoBan);
            if (danhSachNhanVien.Them(nhanVien))
            {
                Console.WriteLine("Thêm nhân viên thành công.");
            }
            else
            {
                Console.WriteLine("Thêm nhân viên thất bại. Mã nhân viên đã tồn tại.");
            }
            break;
        case "2":
            Console.Write("Mã NV cần xóa: ");
            var maNVXoa = Console.ReadLine()?.Trim() ?? "";
            danhSachNhanVien.Xoa(maNVXoa);
            Console.WriteLine(danhSachNhanVien.Tim(maNVXoa) == null ? "Xóa thành công." : "Không tìm thấy nhân viên để xóa.");
            break;
        case "3":
            Console.Write("Nhập mã hoặc chức vụ để tìm: ");
            var tuKhoa = Console.ReadLine()?.Trim() ?? "";
            var ketQua = danhSachNhanVien.Tim(tuKhoa);
            if (ketQua != null)
            {
                Console.WriteLine(ketQua.MoTa());
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
            break;
        case "4":
            danhSachNhanVien.HienThi();
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
