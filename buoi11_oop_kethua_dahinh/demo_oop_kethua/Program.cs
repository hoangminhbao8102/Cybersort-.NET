using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
    Trong C# 1 class con sẽ chỉ được kế thừa từ 1 class cha duy nhất
    + Kế thừa được các thuộc tính và phương thức public, protected
    + Public: Đối tượng được phép thay đổi hoặc sử dụng (method) và class con cũng được phép thay đổi hoặc sử dụng
    + Private: Không cho class con kế thừa cũng như khong cho đối tượng truy cập
    + Protected: Class con có thể thay đổi hoặc sử dụng (method) nhưng đối tượng không được phép (thay đổi, sử dụng)

    Override là hàm ghi đè hàm cha: Khi đối tượng gọi hàm thì sẽ gọi vào hàm override thay vì làm từ class cơ sở
    Từ khóa this và từ khóa base
    + This là thuộc về class đối tượng đó đại diện cho đối tượng đang gọi
    + Base là nói về this của class mà đối tượng kế thừa
*/

GiangVien gv = new GiangVien("Giảng viên Khải");
gv.hoTen = "Giảng viên Khải";
gv.dangKy();
gv.dangNhap();
gv.uploadBaiGiang();

HocVien hv = new HocVien("Học viên Bảo");
hv.hoTen = "Học viên Bảo";
hv.dangKy();
hv.dangNhap();

Mentor mentor = new Mentor("Mentor Chương");
mentor.hoTen = "Mentor Chương";
mentor.dangKy();
mentor.dangNhap();

// ================= Đa hình =================
/*
    Trong hướng đối tượng bao gồm 2 hàm ý
    + Kế thừa: class con kế thừa được những thuộc tính và phương thức của cha bao gồm cả phần xử lý của phương thức
    + Đa hình: thì class dẫn xuất (derived - lớp con) chỉ kế thừa phương thức cùng tên với interface cha.
    Ví dụ:
    + Hình tròn => tình chu vi, diện tích (thuộc tính bán kính)
    + Hình vuông => tình chu vi, diện tích (thuộc tính cạnh)
    + Hình đa giác => tình chu vi, diện tích (thuộc tính các cạnh)

    Interface 
    Abstract
*/

HinhVuong hvuong = new HinhVuong();
hvuong.canh = 10;

HinhTron ht = new HinhTron();
ht.banKinh = 5;

HinhThoi hthoi = new HinhThoi();
hthoi.canh = 5;
hthoi.cheo1 = 10;
hthoi.cheo2 = 20;

List<Hinh> lstHinh = new List<Hinh>();
lstHinh.Add(hvuong);
lstHinh.Add(ht);

foreach (Hinh hinh in lstHinh)
{
    hinh.tinhChuVi();
    hinh.tinhDienTich();
    if (hinh is ChuVi hinhTinhChuVi)
    {
        hinhTinhChuVi.tinhChuVi();
    }
    if (hinh is DienTich hinhTinhDienTich)
    {
        hinhTinhDienTich.tinhDienTich();
    }
}

List<NguoiDung> lstNguoiDung = new List<NguoiDung>();
GiangVien gv1 = new GiangVien("Giảng viên khải");
HocVien hv1 = new HocVien("Học viên nam");
Mentor mt1 = new Mentor("Mentor chương");

lstNguoiDung.Add(gv1);
lstNguoiDung.Add(hv1);
lstNguoiDung.Add(mt1);

foreach (NguoiDung nd in lstNguoiDung)
{
    nd.dangNhap();
}