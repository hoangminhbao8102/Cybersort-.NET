namespace Solid.I;

public interface ITinhLuongService
{
    double CalculateSalary(NhanVien nhanVien);
}

public interface IHienThiThongTinServices
{
    void DisplayEmployeeInfo(NhanVien nhanVien);
}

public class NhanVienServiceClone : ITinhLuongService, IHienThiThongTinServices
{
    public double CalculateSalary(NhanVien nhanVien)
    {
        return nhanVien.Salary * nhanVien.HoursWorked;
    }

    public void DisplayEmployeeInfo(NhanVien nhanVien)
    {
        Console.WriteLine($"ID: {nhanVien.Id}\nHọ tên: {nhanVien.Name}\nChức vụ: {nhanVien.Position}\nLương: {CalculateSalary(nhanVien)}");
    }
}