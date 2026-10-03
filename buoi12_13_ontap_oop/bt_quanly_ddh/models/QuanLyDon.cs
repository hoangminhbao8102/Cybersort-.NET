using System.Text.Json;

public class QuanLyDon
{
    private const string TenFileDuLieu = "donhang.json";

    private class DonHangLuu
    {
        public string LoaiDon { get; set; } = "Thuong";
        public DonHang DonHang { get; set; } = new DonHang();
    }

    // Tạo list là class cha có thể add element (phần từ con vào được)
    public List<DonHang> lstDonHang = new List<DonHang>();
    public int chonChucNang { get; set; } = 0;

    public void hienThiMenu()
    {
        Console.WriteLine("------------------ Chương trình quản lý đơn hàng ------------------\n1. Thêm dơn hàng\n2. Xóa đơn hàng\n3. Sửa địa chỉ\n4. Tìm đơn hàng theo tên khách hàng\n5. Hiển thị tất cả đơn hàng\n6. Tính tổng tiền tất cả đơn\n7. Tính tổng phí giao hàng\n8. Lưu đơn hàng JSON\n9. Load đơn hàng JSON\n10. Thoát");

        Console.Write("Mời bạn chọn chức năng: ");
        this.chonChucNang = Convert.ToInt32(Console.ReadLine());

        switch (this.chonChucNang)
        {
            case 1:
                {
                    this.ThemDonHang();
                };
                break;
            case 2:
                {
                    this.XoaDonHang();
                };
                break;
            case 3:
                {
                    this.SuaDiaChi();
                };
                break;
            case 4:
                {
                    this.TimDonHangTheoKhachHang();
                };
                break;
            case 5:
                {
                    this.HienThiTatCaDonHang();
                };
                break;
            case 6:
                {
                    this.TinhTongTienTatCaDH();
                };
                break;
            case 7:
                {
                    this.TinhTongPhiGiaoHang();
                };
                break;
            case 8:
                {
                    this.LuuDonHang();
                };
                break;
            case 9:
                {
                    this.LoadDonHang();
                };
                break;
            case 10:
                {

                }
                return;
            
        }
    }

    public void ThemDonHang()
    {
        Console.Write("Chọn loại đơn (1 - thường, 2 - giao nhanh): ");
        string? luaChon = Console.ReadLine();

        DonHang donHang = luaChon == "2"
            ? new DonHangGiaoNhanh()
            : new DonHang();

        donHang.nhapThongTinDonHang();
        this.lstDonHang.Add(donHang);
        Console.WriteLine("Đã thêm đơn hàng.");

        this.hienThiMenu();
    }

    public void HienThiTatCaDonHang()
    {
        if (this.lstDonHang.Count == 0)
        {
            Console.WriteLine("Chưa có đơn hàng nào.");
            return;
        }

        foreach (DonHang donHang in this.lstDonHang)
        {
            Console.WriteLine(donHang.moTaDonHang());
            Console.WriteLine("------------------------------");
        }

        this.hienThiMenu();
    }

    public void LuuDonHang()
    {
        List<DonHangLuu> duLieu = this.lstDonHang
            .Select(donHang => new DonHangLuu
            {
                LoaiDon = donHang is DonHangGiaoNhanh ? "GiaoNhanh" : "Thuong",
                DonHang = donHang
            })
            .ToList();

        JsonSerializerOptions tuyChon = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(duLieu, tuyChon);
        File.WriteAllText(Path.Combine(AppContext.BaseDirectory, TenFileDuLieu), json);
        Console.WriteLine($"Đã lưu {duLieu.Count} đơn hàng vào {TenFileDuLieu}.");

        this.hienThiMenu();
    }

    public void LoadDonHang()
    {
        if (!File.Exists(TenFileDuLieu))
        {
            Console.WriteLine($"Không tìm thấy file {TenFileDuLieu}.");
            return;
        }

        string json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, TenFileDuLieu));
        List<DonHangLuu>? duLieu = JsonSerializer.Deserialize<List<DonHangLuu>>(json);

        if (duLieu == null)
        {
            Console.WriteLine("Dữ liệu đơn hàng không hợp lệ.");
            return;
        }

        this.lstDonHang.Clear();
        int maDonLonNhat = 0;

        foreach (DonHangLuu donHangLuu in duLieu)
        {
            DonHang donHang = donHangLuu.LoaiDon == "GiaoNhanh"
                ? new DonHangGiaoNhanh()
                : new DonHang();

            donHang.maDonHang = donHangLuu.DonHang.maDonHang;
            donHang.tenKhach = donHangLuu.DonHang.tenKhach;
            donHang.diaChi = donHangLuu.DonHang.diaChi;
            donHang.tienHang = donHangLuu.DonHang.tienHang;
            donHang.soKM = donHangLuu.DonHang.soKM;
            this.lstDonHang.Add(donHang);
            maDonLonNhat = Math.Max(maDonLonNhat, donHang.maDonHang);
        }

        DonHang.MaDonTuDong = maDonLonNhat + 1;
        Console.WriteLine($"Đã tải {this.lstDonHang.Count} đơn hàng từ {TenFileDuLieu}.");

        this.hienThiMenu();
    }

    public void XoaDonHang()
    {
        Console.Write("Nhập vào mã đơn cần xóa: ");
        int maDonXoa = Convert.ToInt32(Console.ReadLine());

        // Tìm ra đơn hàng cần xóa
        DonHang? dh = this.lstDonHang.SingleOrDefault(item => item.maDonHang == maDonXoa);
        // Nếu tìm được đơn hàng thì tr3 về object đơn hàng, nếu không tìm thấy sẽ trả về null
        if (dh != null)
        {
            this.lstDonHang.Remove(dh);
        }
        // Hiển thị lại menu
        // This.luuDonHang(); nếu muốn xóa xong lưu vào json file thì gọi this.luuDonHang
        this.hienThiMenu();
    }

    public void TimDonHangTheoKhachHang()
    {
        // Tìm => kết quả trả về sẽ là List (hoặc collection)
        List<DonHang> lstDHTimKiem = new List<DonHang>(); // {}
        Console.Write("Nhập vào tên khách hàng: ");
        string tenKH = Console.ReadLine() ?? "0";

        lstDHTimKiem = this.lstDonHang.Where(item => item.tenKhach == tenKH).ToList();

        if (lstDHTimKiem.Count > 0)
        {
            Console.Write($"Tìm thấy {lstDHTimKiem.Count} đơn hàng");
            foreach (DonHang dh in lstDHTimKiem)
            {
                if (dh is DonHangGiaoNhanh dhNhanh)
                {
                    dhNhanh.moTaDonHang();
                }
                else
                {
                    dh.moTaDonHang();
                }
            }
        }
        else
        {
            Console.Write($"Không tìm thấy đơn hàng của khách hàng {tenKH}");
        }
        // Hiển thị lại menu
        this.hienThiMenu();
    }

    public void TinhTongPhiGiaoHang()
    {
        Console.WriteLine($"Tổng phí giao hàng của {this.lstDonHang.Count} đơn hàng: ");
        double tongPhi = this.lstDonHang.Sum(item => 
        {
            double phiGiao = 0;
            if (item is DonHangGiaoNhanh donNhanh)
            {
                phiGiao = donNhanh.tinhPhiGiaoHang();
            }
            else{
                phiGiao = item.tinhPhiGiaoHang();
            }

            return phiGiao; // Phí giao trong phần tử
        });
        Console.Write($"{tongPhi}");

        this.hienThiMenu();
    }

    public void TinhTongTienTatCaDH()
    {
        Console.Write($"Tổng tiền hàng của {this.lstDonHang.Count} đơn hàng: ");
        double tongTienHang = this.lstDonHang.Sum(item => item.tienHang);
        
        Console.WriteLine($"{tongTienHang}");

        this.hienThiMenu();
    }

    public void SuaDiaChi()
    {
        Console.Write("Nhập vào mã đơn cần sửa địa chỉ: ");
        int maDonCanSua = Convert.ToInt32(Console.ReadLine());

        DonHang? donHang = this.lstDonHang
            .SingleOrDefault(item => item.maDonHang == maDonCanSua);

        if (donHang == null)
        {
            Console.WriteLine($"Không tìm thấy đơn hàng có mã {maDonCanSua}.");
            this.hienThiMenu();
            return;
        }

        Console.Write("Nhập địa chỉ mới: ");
        donHang.diaChi = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Đã cập nhật địa chỉ đơn hàng.");

        this.hienThiMenu();
    }
}