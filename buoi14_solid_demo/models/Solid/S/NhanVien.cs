public class NhanVien
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public double HoursWorked { get; set; }

    public NhanVien()
    {
        Id = 0;
        Name = string.Empty;
        Position = string.Empty;
        Salary = 0.0;
        HoursWorked = 0.0;
    }

    public NhanVien(int id, string name, string position, double salary, double hoursWorked)
    {
        Id = id;
        Name = name;
        Position = position;
        Salary = salary;
        HoursWorked = hoursWorked;
    }
}