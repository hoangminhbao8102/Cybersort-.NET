DanhSachSanPham app = new DanhSachSanPham();
int luaChon;

do
{
    app.HienThiMenu();

    Console.Write("Vui lòng chọn chức năng: ");
    luaChon = int.Parse(Console.ReadLine() ?? "0");

    switch (luaChon)
    {
        case 1:
            app.ThemSanPham();
            break;

        case 2:
            app.HienThiDanhSach();
            break;

        case 3:
            app.TinhTongDoanhThu();
            break;

        case 4:
            app.XoaSanPham();
            break;

        case 5:
            Console.WriteLine("Đã thoát chương trình!");
            break;

        default:
            Console.WriteLine("Lựa chọn không hợp lệ!");
            break;
    }

} while (luaChon != 5);