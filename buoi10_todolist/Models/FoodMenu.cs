namespace Models;

public class FoodMenu
{
    //           0               1      2
    // {id, taskName, status}, {...}, {...} 
    public List<Food> foodList = new List<Food>(); // {}
    public int chon { get; set; }

    public void DisplayMenu()
    {
        Console.Write($"=== Chương trình quản lý món ăn ===\n1/ Thêm Món Ăn Mới \n2/ Hiển thị Menu \n3/ Xóa Món Ăn \n4/ Thoát \nHãy chọn chức năng: ");

        this.chon = Convert.ToInt32(Console.ReadLine());

        // Sau khi người dùng chọn thực hiện hàm tương ứng
        switch (this.chon)
        {
            case 1:
                {
                    this.AddFood();
                }
                break;
            case 2:
                {
                    this.DisplayFoodList();
                }
                break;
            case 3:
                {
                    this.DeleteFood();
                }
                break;
            case 4:
                {
                    // Thoát chương trình.
                }
                break;
            default:
                break;
        }

    }

    public void AddFood()
    {
        // Input: Lấy từ người dùng nhập vào
        Food newFood = new Food();
        newFood.id = this.foodList.Count == 0
            ? 1
            : this.foodList.Max(food => food.id) + 1;
        Console.Write("Nhập tên món ăn: ");
        newFood.foodName = Console.ReadLine() ?? "";
        Console.Write("Nhập giá của món ăn: ");
        newFood.giaTien = int.Parse(Console.ReadLine() ?? "0");

        this.foodList.Add(newFood);
        Console.WriteLine($"Món ăn '{newFood.foodName}' đã được thêm với giá {newFood.giaTien}.");

        this.DisplayMenu();
    }

    public void DisplayFoodList()
    {
        foreach (Food food in this.foodList)
        {
            Console.WriteLine($"{food.foodName}: {food.giaTien}");
        }

        // Hiển thị lại menu
        this.DisplayMenu();
    }

    public void DeleteFood()
    {
        Console.WriteLine("Chọn món ăn muốn xóa: ");
        foreach (Food food in this.foodList)
        {
            Console.WriteLine($"{food.id}. {food.foodName}");
        }

        Console.Write("Chọn món ăn muốn xóa: ");
        int idNguoiDungChon = Convert.ToInt32(Console.ReadLine());

        Food? foodDuocChon = this.foodList.Find(food => food.id == idNguoiDungChon);

        // Khi lấy ra được task
        if (foodDuocChon != null) 
        {
            this.foodList.Remove(foodDuocChon);
            Console.WriteLine($"Món ăn '{foodDuocChon.foodName}' đã được xóa.");
        }
        
        // Hiển thị lại menu
        this.DisplayMenu();
    }
}