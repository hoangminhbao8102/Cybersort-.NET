public class TinhLuongServices
{
    public double CalculateSalary(NhanVien nhanVien)
    {
        return nhanVien.Salary * nhanVien.HoursWorked;
    }
}

public class HienThiThongTinServices
{
    public TinhLuongServices TinhLuongServices { get; set; } = new TinhLuongServices();
    public void DisplayEmployeeInfo(NhanVien nhanVien)
    {
        Console.WriteLine($"ID: {nhanVien.Id}\nHọ tên: {nhanVien.Name}\nChức vụ: {nhanVien.Position}\nLương: {TinhLuongServices.CalculateSalary(nhanVien)}");
    }
}

public class NhanVienServices
{
    public TinhLuongServices TinhLuongServices { get; set; } = new TinhLuongServices();
    public HienThiThongTinServices HienThiThongTinServices { get; set; } = new HienThiThongTinServices();
}