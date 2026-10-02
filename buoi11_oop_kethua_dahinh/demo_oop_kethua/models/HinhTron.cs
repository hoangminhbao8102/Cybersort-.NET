public class HinhTron : Hinh // ChuVi, DienTich // implements
{
    public int banKinh { get; set; }
    
    public double tinhChuVi()
    {
        Console.WriteLine($"Hình tròn tính chu vi {this.banKinh * 2 * Math.PI}");
        return this.banKinh * 2 * Math.PI;
    }

    public double tinhDienTich()
    {
        Console.WriteLine($"Hình tròn tính diện tích {this.banKinh * this.banKinh * Math.PI}");
        return this.banKinh * this.banKinh * Math.PI;
    }
}