public class NhanVienExtend : NhanVien, ICalculateSalary
{
    public int NewHoursWorked { get; set; }

    public NhanVienExtend() : base()
    {
        NewHoursWorked = 0;
    }

    public NhanVienExtend(int id, string name, string position, double salary, double hoursWorked, int newHoursWorked)
        : base(id, name, position, salary, hoursWorked)
    {
        NewHoursWorked = newHoursWorked;
    }

    public virtual double CalculateNewSalary()
    {
        return Salary * NewHoursWorked;
    }
}

public class NhanVienExtendWithBonus : NhanVienExtend, ICalculateSalary
{
    public double Bonus { get; set; } = 10;

    public NhanVienExtendWithBonus() : base()
    {
        Bonus = 0.0;
    }

    public NhanVienExtendWithBonus(int id, string name, string position, double salary, double hoursWorked, int newHoursWorked, double bonus)
        : base(id, name, position, salary, hoursWorked, newHoursWorked)
    {
        Bonus = bonus;
    }

    public override double CalculateNewSalary()
    {
        return base.CalculateNewSalary() + Bonus;
    }
}

public interface ICalculateSalary
{
    public double CalculateNewSalary();
}