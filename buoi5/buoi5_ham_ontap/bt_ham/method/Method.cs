public class Method
{
    /// <summary>
    /// Hàm InSao dùng để in ra số lượng sao theo yêu cầu
    /// </summary>
    /// <param name="soSao">Số nguyên dương</param>
    /// <returns>Chuỗi chứa các sao</returns>
    public static string InSao(int soSao = 5) // Input: số lượng sao muốn in ra, mặc định là 5
    {
        string kq = ""; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để in ra số lượng sao theo yêu cầu
        for (int i = 0; i < soSao; i++)
        {
            kq += "*";
        }
        return kq; // return kết quả ra ngoài
    }

    public static bool ktSoNguyenTo(int n) // Input: số nguyên dương n
    {
        bool kq = true; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để kiểm tra xem số đó có phải là số nguyên tố không
        if (n < 2)
            kq = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    kq = false;
                    break;
                }
            }
        }
        return kq;
    }

    public static int hamDemo(ref int n) // Input: số nguyên dương n
    {
        int kq = 20; // Khai báo biến kq để lưu kết quả (Khai báo output)
        n = 20; // Gán giá trị 20 cho n
        return kq; // return kết quả ra ngoài
    }

    public static void nhapThongTin(ref string hoTen, ref string email, ref string soDT) // Input: họ tên, email, số điện thoại
    {
        Console.Write("Nhập vào họ tên: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhập vào email: ");
        email = Console.ReadLine() ?? "";
        Console.Write("Nhập vào số điện thoại: ");
        soDT = Console.ReadLine() ?? "";
    }

    public static void nhapThongTinOut(out string hoTen, out string email, out string soDT) // Input: họ tên, email, số điện thoại
    {
        Console.Write("Nhập vào họ tên: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhập vào email: ");
        email = Console.ReadLine() ?? "";
        Console.Write("Nhập vào số điện thoại: ");
        soDT = Console.ReadLine() ?? "";
    }

    // Viết chương trình cho phép người dùng nhập vào số nguyên n, sau đó in ra các số nguyên tố từ 2 đến n.
    public static string inDaySoNguyenTo(int n) // Input: số nguyên dương n
    {
        string kq = ""; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để in ra các số nguyên tố từ 2 đến n
        for (int i = 2; i <= n; i++)
        {
            if (ktSoNguyenTo(i)) // Gọi phương thức ktSoNguyenTo để kiểm tra số nguyên tố
            {
                kq += i + " "; // Nếu là số nguyên tố thì thêm vào kết quả
            }
        }
        return kq; // return kết quả ra ngoài
    }

    // Viết chương trình cho phép người dùng nhập vào một chuỗi ví dụ "143244534" in ra những số nguyên tố trong chuỗi đó.
    // Cách 1: Dùng vòng lặp for để kiểm tra từng ký tự trong chuỗi, nếu ký tự đó là số nguyên tố thì thêm vào kết quả.
    public static string inSoNguyenToTrongChuoi(string chuoi) // Input: chuỗi ký tự
    {
        string kq = ""; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để kiểm tra từng ký tự trong chuỗi
        for (int i = 0; i < chuoi.Length; i++)
        {
            int so = int.Parse(chuoi[i].ToString()); // Chuyển ký tự thành số nguyên
            if (ktSoNguyenTo(so)) // Gọi phương thức ktSoNguyenTo để kiểm tra số nguyên tố
            {
                kq += so + " "; // Nếu là số nguyên tố thì thêm vào kết quả
            }
        }
        return kq; // return kết quả ra ngoài
    }
    /* Cách 2: Tách 2 hàm
    - Hàm 1: Kiểm tra input: n có phải là số nguyên tố không.
    - Hàm 2: Kiểm tra số đó có tồn tại trong chuỗi không, nếu có thì thêm vào kết quả.
    */

    public static bool ktTonTai(int so, string chuoi) // Input: số nguyên dương so, chuỗi ký tự
    {
        bool kq = false; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để kiểm tra từng ký tự trong chuỗi
        for (int i = 0; i < chuoi.Length; i++)
        {
            int soTrongChuoi = int.Parse(chuoi[i].ToString()); // Chuyển ký tự thành số nguyên
            if (so == soTrongChuoi) // Nếu số đó tồn tại trong chuỗi thì gán kq = true và break
            {
                kq = true;
                break;
            }
        }
        return kq; // return kết quả ra ngoài
    }

    public static string inDaySoNguyenToTrongChuoi(string chuoi) // Input: chuỗi ký tự
    {
        string kq = ""; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để kiểm tra từng ký tự trong chuỗi
        for (int i = 0; i < chuoi.Length; i++) // Chỉ kiểm tra các số từ 0 đến 9 vì các số lớn hơn 9 không phải là số nguyên tố
        {
            int kyTu = Convert.ToInt16(chuoi[i].ToString()); // Lấy ký tự tại vị trí i
            // Kiểm tra ký tự đó có phải là số nguyên tố không, nếu có thì thêm vào kết quả
            bool isSoNguyenTo = ktSoNguyenTo(int.Parse(kyTu.ToString())); // Gọi phương thức ktSoNguyenTo để kiểm tra số nguyên tố
            bool isTonTai = ktTonTai(int.Parse(kyTu.ToString()), chuoi); // Gọi phương thức ktTonTai để kiểm tra số đó có tồn tại trong chuỗi không
            if (isSoNguyenTo == true && isTonTai == false) // Nếu là số nguyên tố và tồn tại trong chuỗi thì thêm vào kết quả
            {
                kq += kyTu + " "; // Nếu là số nguyên tố thì thêm vào kết quả
            }
        }
        return kq; // return kết quả ra ngoài
    }

    // Viết chương trình cho phép người dùng nhập vào một chuỗi để đếm số lượng ký tự từ cuối chuỗi đến khi gặp ký tự đầu tiên không phải là khoảng trắng.
    // Cách 1: Dùng vòng lặp for để đếm số lượng ký tự từ cuối chuỗi đến khi gặp ký tự đầu tiên không phải là khoảng trắng.
    public static int demDoDaiTuCuoiCung(string chuoi) // Input: chuỗi ký tự
    {
        int kq = 0; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để đếm số lượng ký tự từ cuối chuỗi đến khi gặp ký tự đầu tiên không phải là khoảng trắng
        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            if (chuoi[i] != ' ') // Nếu ký tự đó không phải là khoảng trắng thì tăng kq lên 1
            {
                kq++;
            }
            else // Nếu ký tự đó là khoảng trắng thì break
            {
                break;
            }
        }
        return kq; // return kết quả ra ngoài
    }

    // Cách 2: Tách 2 hàm
    public static int timKhoangTrangCuoiCung(string chuoi) // Input: chuỗi ký tự
    {
        int kq = 0; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng vòng lặp for để tìm vị trí của ký tự khoảng trắng cuối cùng trong chuỗi
        for (int i = chuoi.Length - 1; i >= 0; i--)
        {
            if (chuoi[i] == ' ') // Nếu ký tự đó là khoảng trắng thì gán kq = i và break
            {
                kq = i;
                break;
            }
        }
        return kq; // return kết quả ra ngoài
    }

    public static int demDoDaiTuCuoiCung2(string chuoi) // Input: chuỗi ký tự
    {
        int kq = 0; // Khai báo biến kq để lưu kết quả (Khai báo output)
        // Process: Dùng phương thức timKhoangTrangCuoiCung để tìm vị trí của ký tự khoảng trắng cuối cùng trong chuỗi
        int viTriKhoangTrang = timKhoangTrangCuoiCung(chuoi); // Gọi phương thức timKhoangTrangCuoiCung để tìm vị trí của ký tự khoảng trắng cuối cùng trong chuỗi
        kq = chuoi.Length - viTriKhoangTrang - 1; // Tính số lượng ký tự từ cuối chuỗi đến khi gặp ký tự đầu tiên không phải là khoảng trắng
        return kq; // return kết quả ra ngoài
    }
}