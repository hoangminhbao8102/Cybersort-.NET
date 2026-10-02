namespace Models;

public class Menu
{
    //           0               1      2
    // {id, taskName, status}, {...}, {...} 
    public List<Task> listTask = new List<Task>(); // {}
    public string Title { get; set; } = string.Empty;
    public int chon { get; set; }

    public void DisplayMenu()
    {
        Console.Write($"=== {this.Title} ===\n1/ Thêm task \n2/ Hiển thị nội dung task \n3/ Chọn task hoàn thành \n4/ Xóa task \n5/ Thoát \nHãy chọn chức năng: ");

        this.chon = Convert.ToInt32(Console.ReadLine());

        // Sau khi người dùng chọn thực hiện hàm tương ứng
        switch (this.chon)
        {
            case 1:
                {
                    this.AddTask();
                }
                break;
            case 2:
                {
                    this.DisplayTaskList();
                }
                break;
            case 3:
                {
                    this.CheckDoneTask();
                }
                break;
            case 4:
                {
                    this.XoaTask();
                }
                break;
            case 5:
                {
                    // Thoát chương trình.
                }
                break;
            default:
                break;
        }

    }

    public void AddTask()
    {
        // Input: Lấy từ người dùng nhập vào
        Task newTask = new Task();
        Console.Write("Nhập vào task id: ");
        newTask.id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập vào tên task: ");
        newTask.taskName = Console.ReadLine() ?? "";

        // Mặc định task thêm mới là chưa làm
        newTask.status = false;

        // Thêm task mới vào list task
        this.listTask.Add(newTask);
        
        Console.WriteLine("Hiển thị lại menu.");
        this.DisplayMenu();
    }

    public void DisplayTaskList()
    {
        // Chạy vòng lặp lấy ra từng task hiển thị
        foreach (Task task in this.listTask)
        {
            Console.WriteLine($"{task.id}. {task.taskName} - {((task.status == true) ? "Done" : "Pending")}");
        }

        // Hiển thị lại menu
        this.DisplayMenu();
    }

    public void CheckDoneTask()
    {
        Console.Write("Nhập id task cần hoàn thành: ");
        // Input: Lấy mã từ người dùng nhập vào để xác định task hoàn thành
        int idNguoiDungChon = Convert.ToInt32(Console.ReadLine());
        // Tìm ra mã task chứa trong task list
        Task? taskDuocChon = this.listTask.Find(task => task.id == idNguoiDungChon);
        // Lấy ra và thay đổi trạng thái task
        taskDuocChon!.status = true;
        // Hiển thị lại menu
        this.DisplayMenu();
    }

    public void XoaTask()
    {
        Console.Write("Nhập id task cần xóa: ");
        int idNguoiDungChon = Convert.ToInt32(Console.ReadLine());

        Task? taskDuocChon = this.listTask.Find(task => task.id == idNguoiDungChon);

        // Khi lấy ra được task
        if (taskDuocChon == null)
        {
            Console.WriteLine("Không tìm thấy task cần xóa.");
        }
        else
        {
            this.listTask.Remove(taskDuocChon);
            Console.WriteLine("Đã xóa task.");
        }
        
        // Hiển thị lại menu
        this.DisplayMenu();
    }
}