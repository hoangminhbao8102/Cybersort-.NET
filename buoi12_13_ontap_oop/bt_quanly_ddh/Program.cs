using System.Text;

Console.OutputEncoding = Encoding.UTF8;

/*
DonHang dhThuong = new DonHang();
dhThuong.nhapThongTinDonHang();
string kq1 = dhThuong.moTaDonHang();
Console.WriteLine($"{kq1}");

DonHangGiaoNhanh dhGiaoNhanh = new DonHangGiaoNhanh();
dhGiaoNhanh.nhapThongTinDonHang();
string kq2 = dhGiaoNhanh.moTaDonHang();
Console.WriteLine($"{kq2}");
*/

QuanLyDon app = new QuanLyDon();
app.hienThiMenu();
app.LoadDonHang(); // load dữ liệu json khi vừa mở app