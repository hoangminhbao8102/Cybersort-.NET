public class GiangVien : NguoiDung
{
    public List<string> DanhSachLopDangDay = new List<string>();

    public GiangVien(string name) : base(name)
    {
        // Code mấy thứ khác cho giảng viên
    }

    public void uploadBaiGiang()
    {
        this.hoTen = "Xyz";
        Console.WriteLine($"{this.hoTen} thực hiện chức năng upload bài giảng");
    }
    public override void dangNhap()
    {
        // Console.WriteLine($"{this.hoTen}");
        // Console.WriteLine($"{base.hoTen}");

        base.dangNhap();

        Console.WriteLine("Thực hiện google 2FA");
    }
}