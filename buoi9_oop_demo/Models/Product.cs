public class Product
{
    public static int STT = 0;
    public int MaSanPham { get; set; }
    public string TenSanPham { get; set; }
    public double Gia { get; set; }
    public string HinhAnh { get; set; }

    public Product()
    {
        STT++;
        this.MaSanPham = STT;
        this.TenSanPham = $"Sản phẩm {this.MaSanPham}";
        this.Gia = this.MaSanPham * 1000;
        this.HinhAnh = "";
    }

    public void hienThiThongTin()
    {
        Console.WriteLine($"-------- Thông tin sản phẩm {this.MaSanPham} --------\nMã sản phẩm: {this.MaSanPham}\nTên sản phẩm: {this.TenSanPham}\nGiá bán: {this.Gia}");
    }
}