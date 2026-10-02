namespace Models;

public class Food
{
    // public static int idTangDan = 1;
    public int id { get; set; }
    public string foodName { get; set; } = string.Empty;
    public int giaTien { get; set; }
    /* public Food(Parameters)
    {
       // Hàm khởi tạo không tham số - hàm khởi tạo mặc định
       this.id = Food.idTangDan;
       Food.idTangDan++; 
    }
    */
}