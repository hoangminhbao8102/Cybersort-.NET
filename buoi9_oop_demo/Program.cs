using System.Text;
using System.Text.Json;
// ===== Phương pháp lập trình hướng đối tượng =====

// Tạo ra 1 đối tượng từ class (kiểu dữ liệu ta định nghĩa)
NhanVien nv = new NhanVien();
nv.HienThiThongTin();
// Lập trình hướng đối tượng là đưa các biến về hàm về đúng vị trí của nó (Đối tượng)

// Yêu cầu: Xây dựng class sinh viên chứa những thông tin: maSV, tenSV, diemToan, diemLy, diemHoa và viết 2 phương thức tinhDiemTrungBinh và hienThiThongTinSinhVien
Console.OutputEncoding = Encoding.UTF8;
SinhVien sv = new SinhVien(); // Nhập được thông ti sinh viên
// Hiển thị thông tin sinh viên
sv.HienThiThongTin();

SinhVien sv1 = new SinhVien();

// => Tão ra 5 biến khác và 4 hàm khác trong sv1

sv1.HienThiThongTin();
sv1.NhapThongTinSinhVien();
sv1.NhapThongTinSinhVien("SV001", "Nguyễn Văn A", 1, 2, 3);

SinhVien sv2 = new SinhVien("Bảo");

SinhVien sv3 = sv2.TaoMoiSinhVien(); // Khởi tạo sao chép vừa tạo và vừa sao chép giá trị

SinhVien sv4 = new SinhVien();
sv4.MaSV = "5";
sv4.TenSV = "Sinh Viên 4";

SinhVien sv5 = sv4;
sv5.MaSV = "5";
sv5.TenSV = "Sinh Viên 5";

Console.WriteLine($"SV4: {JsonSerializer.Serialize(sv4)}");
Console.WriteLine($"SV5: {JsonSerializer.Serialize(sv5)}");

// Static thuộc phạm vi class không phải phạm vi instance
// Static chỉ có 1 hàm duy nhất trong class

SinhVien sv6 = new SinhVien();
SinhVien sv7 = new SinhVien();
SinhVien sv8 = new SinhVien();

Console.WriteLine($"Mã sv7: {sv7.MaSV}\nMã sv8: {sv8.MaSV}");

// Tạo List sản phẩm
List<Product> lstProduct = new List<Product>();

Product prod1 = new Product();
Product prod2 = new Product();
Product prod3 = new Product();

lstProduct.Add(prod1);
lstProduct.Add(prod2);
lstProduct.Add(prod3);

Console.WriteLine($"Danh sách sản phẩm: {JsonSerializer.Serialize(lstProduct)}");

foreach (Product item in lstProduct)
{
    item.hienThiThongTin();
}