public class HocVien : NguoiDung
{
    public List<string> DanhSachLopDangHoc = new List<string>();

    public HocVien(string name) : base(name)
    {
        // Code mấy thứ khác cho học viên
    }

    public void nopBai()
    {
        Console.WriteLine("Thực hiện chức năng nộp bài");
    }
}