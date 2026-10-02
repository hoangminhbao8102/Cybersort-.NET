public class Mentor : NguoiDung
{
    public List<string> DanhSachLopDangHoTro = new List<string>();

    public Mentor(string name) : base(name)
    {
        // Code mấy thứ khác cho mentor
    }

    public void chamBai()
    {
        Console.WriteLine("Thực hiện chức năng chấm bài");
    }
}