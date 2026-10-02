public class HinhVuong : Hinh // ChuVi, DienTich
{
    public int canh { get; set; }

    public double tinhChuVi()
    {
        Console.WriteLine($"Hình vuông tính chu vi {this.canh * 4}");
        return this.canh * 4;
    }

    public double tinhDienTich()
    {
        Console.WriteLine($"Hình vuông tính diện tích {this.canh * this.canh}");
        return this.canh * this.canh;
    }
}