public class HinhThoi : Hinh
{
    public int canh { get; set; }
    public int cheo1 { get; set; }
    public int cheo2 { get; set; }
    public double tinhChuVi()
    {
        Console.WriteLine($"Hình thoi tính chu vi {this.canh * 4}");
        return this.canh * 4;
    }

    public double tinhDienTich()
    {
        Console.WriteLine($"Hình thoi tính diện tích {(this.cheo1 * this.cheo2) / 2}");
        return (this.cheo1 * this.cheo2) / 2;
    }
}