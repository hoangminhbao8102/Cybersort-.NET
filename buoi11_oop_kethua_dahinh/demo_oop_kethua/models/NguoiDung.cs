public class NguoiDung
{
    // Các thuộc tính public của lớp cơ sở sẽ được lớp con kế thừa
    // private: Lớp con không được kế thừa
    // public: Lớp con được kế thừa và bên ngoài khi đối tượng mới được thay đổi
    public string email { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    public string hoTen { get; set; } = string.Empty;
    public string soDienThoai { get; set; } = string.Empty;

    public NguoiDung(string name)
    {
        this.hoTen = name;
    }
    
    public void dangKy()
    {
        Console.WriteLine($"{this.hoTen} thực hiện chức năng đăng ký");
    }
    public virtual void dangNhap()
    {
        Console.WriteLine("Xác thực OTP ...");
        Console.WriteLine($"{this.hoTen} thực hiện chức năng đăng nhập");
    }
}