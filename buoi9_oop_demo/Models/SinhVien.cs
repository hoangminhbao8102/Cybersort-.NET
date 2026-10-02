public class SinhVien // Lớp đối tượng reference type (giống như collection)
{
    // Thuộc tính static không thuộc về đối tượng - chỉ thuộc class
    public static int stt = 0;
    // Phương thức static không thuộc về đối tượng - chỉ thuộc class
    public static void PhatSinhMaSinhVien()
    {
        // Thao tác trên nhiều đối tượng
        SinhVien.stt++;
    }

    // Thông tin lưu trử là thuộc tính - giá trị tính toán được thì không đưa vào lưu trữ
    public string MaSV { get; set; } = string.Empty;
    public string TenSV { get; set; } = string.Empty;
    public double DiemToan { get; set; } = 0;
    public double DiemLy { get; set; } = 0;
    public double DiemHoa { get; set; } = 0; // default value
    // private double DTB : Giá trị tính toán được không đưa vào lưu trữ

    public SinhVien() // Hàm khởi tạo không tham số mặc định
    {
        this.NhapThongTinSinhVien();
        PhatSinhMaSinhVien();
        this.MaSV = SinhVien.stt.ToString();
    }

    public SinhVien(string tenSV)
    {
        this.TenSV = tenSV;
    }

    // Khởi tạo thông qua cách sao chép
    
    public SinhVien TaoMoiSinhVien()
    {
        return (SinhVien) this.MemberwiseClone();
    }

    // Overloading method là hàm có cùng tên nhưng khác nhau về đầu vào {input: số lượng tham số, kiểu dữ liệu của tham số}
    /// <summary>
    /// Đây là hàm truyền tham số trực tiếp vào các thuộc tính mà không cần người dùng nhập
    /// </summary>
    /// <param name="maSV"></param>
    /// <param name="tenSV"></param>
    /// <param name="Toan"></param>
    /// <param name="Ly"></param>
    /// <param name="Hoa"></param> <summary>
    /// 
    /// <param name="maSV"></param>
    /// <param name="tenSV"></param>
    /// <param name="Toan"></param>
    /// <param name="Ly"></param>
    /// <param name="Hoa"></param>

    public void NhapThongTinSinhVien()
    {
        Console.Write("Nhập vào mã nhân viên: ");
        this.MaSV = Console.ReadLine() ?? "0";
        Console.Write("Nhập vào họ tên sinh viên: ");
        this.TenSV = Console.ReadLine() ?? "0";
        Console.Write("Nhập vào điểm Toán: ");
        this.DiemToan = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào điểm Lý: ");
        this.DiemLy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập vào điểm Hóa: ");
        this.DiemHoa = Convert.ToDouble(Console.ReadLine());
    }

    public void NhapThongTinSinhVien(string maSV, string tenSV, double toan, double ly, double hoa)
    {
        this.MaSV = maSV;
        this.TenSV = tenSV;
        this.DiemToan = toan;
        this.DiemLy = ly;
        this. DiemHoa = hoa;
    }

    private double DiemTB()
    {
        return (this.DiemToan + this.DiemLy + this.DiemHoa) / 3;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Mã sinh viên: {this.MaSV}\nTên sinh viên: {this.TenSV}\nĐiểm trung bình: {this.DiemTB()}");
    }

    // Lưu ý từ khóa this: đối tượng nào gọi hàm đến thì this sẽ là đối tượng đó.
}