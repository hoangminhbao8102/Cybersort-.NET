using System.Text.Json;

public class AppQuanLyNhanVien
{
    public List<NhanVien> danhSachNV { get; set; } = new List<NhanVien>();
    public int chonChucNang { get; set; } = 0;
    public void hienThiMenu()
    {
        Console.Write("===== Chương trình quản lý nhân viên =====\n1. Thêm nhân viên\n2. Tìm nhân viên\n3. Thay đổi tên nhân viên\n4. Xóa nhân viên\n5. Hiển thị danh sách nhân viên\n6. Lưu danh sách nhân viên JSON\n7. Load danh sách nhân viên\n8. Thoát\nBạn chọn chức năng nào ? bấm phím tương ứng: ");
        chonChucNang = Convert.ToInt32(Console.ReadLine());

        switch (chonChucNang)
        {
            case 1:
                {
                    this.ThemNhanVien();
                }
                ;
                break;
            case 2:
                {

                }
                ;
                break;
            case 3:
                {

                }
                ;
                break;
            case 4:
                {

                }
                ;
                break;
            case 5:
                {
                    this.XuatDanhSachNhanVien();
                }
                ;
                break;
            case 6:
                {
                    this.LuuDuLieuVaoFileJson();
                }
                ;
                break;
            case 7:
                {
                    this.LayDuLienNhanVienTuFileJson();
                }
                ;
                break;
            case 8:
                {
                    
                }
                ;
                break;
            default:
                break;
        }
    }

    public void ThemNhanVien()
    {
        Console.WriteLine("Bạn muốn thêm nhân viên gì?\n1. Nhân viên văn phòng\n2. Nhân viên sản xuất\n3. Nhân viên kinh doanh");
        int loaiNV = Convert.ToInt32(Console.ReadLine());
        NhanVien nv;
        switch (loaiNV)
        {
            case 1:
                {
                    nv = new NhanVienVanPhong(true);
                }
                break;
            case 2:
                {
                    nv = new NhanVienSanXuat(true);
                }
                break;
            case 3:
                {
                    nv = new NhanVienKinhDoanh(true);
                }
                break;
            default:
                {
                    this.hienThiMenu();
                    return;
                }
        }

        this.danhSachNV.Add(nv);
        this.hienThiMenu();
    }

    public void XuatDanhSachNhanVien()
    {
        // this.danhSachNhanVien = {{nvVP}, {nvKD}, {nvSX}}
        Console.WriteLine("===== Danh sách nhân viên =====");
        foreach (NhanVien nv in this.danhSachNV)
        {
            if (nv is NhanVienKinhDoanh nvKD)
            {
                nvKD.XuatThongTinNhanVien();
            }
            else if (nv is NhanVienSanXuat nvSX)
            {
                nvSX.XuatThongTinNhanVien();
            }
            else if (nv is NhanVienVanPhong nvVP)
            {
                nvVP.XuatThongTinNhanVien();
            }
        }
        // Hiển thị lại menu
        this.hienThiMenu();
    }

    public void LuuDuLieuVaoFileJson()
    {
        // Bước 1: Chuyển List<NhanVien> => string.Json
        string jsonDanhSachNhanVien = JsonSerializer.Serialize(this.danhSachNV);
        string pathFile = Path.Combine(AppContext.BaseDirectory, "data.json");
        // Bước 2: Lưu text json vào file ("path" đường dẫn file) tương ứng
        File.WriteAllText(pathFile, jsonDanhSachNhanVien);
    }

    public void LayDuLienNhanVienTuFileJson()
    {
        if (File.Exists("data.json"))
        {
            // Bước 1: Đọc dữ liệu từ file data.json => string của C#
            string pathFile = Path.Combine(AppContext.BaseDirectory, "data.json");
            string jsonData = File.ReadAllText(pathFile);
            // Bước 2: Chuyển từ string json đọc từ file ra List<NhanVien> tương ứng
            List<NhanVien>? dataJson = JsonSerializer.Deserialize<List<NhanVien>>(jsonData);
            if (dataJson != null) // Kiểm tra data lấy được
            {
                foreach (NhanVien nv in dataJson)
                {
                    NhanVien nvData = new NhanVien();
                    if (nv.loaiNhanVien == 1)
                    {
                        // Tạo ra nhân viên kinh doanh dưa vào this.danhSachNhanVien
                        nvData = new NhanVienKinhDoanh(nv.maNhanVien, nv.tenNhanVien, nv.luongCoBan, nv.soGioLam, nv.loaiNhanVien);
                    }
                    else if (nv.loaiNhanVien == 2)
                    {
                        // Tạo ra nhân viên sản xuất dưa vào this.danhSachNhanVien
                        nvData = new NhanVienSanXuat(nv.maNhanVien, nv.tenNhanVien, nv.luongCoBan, nv.soGioLam, nv.loaiNhanVien);
                    }
                    else if (nv.loaiNhanVien == 3)
                    {
                        // Tạo ra nhân viên văn phòng dưa vào this.danhSachNhanVien
                        nvData = new NhanVienVanPhong(nv.maNhanVien, nv.tenNhanVien, nv.luongCoBan, nv.soGioLam, nv.loaiNhanVien);
                    }
                    // Thêm nhân viên vào danh sách nhân viên ngược lại
                    this.danhSachNV.Add(nvData);
                }
            }
        }
    }
}