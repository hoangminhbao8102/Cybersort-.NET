using System.Text;

#region Nhập số sao
/*
    Viết chương trình nhập vào số lượng sao muốn in ra, mặc định là 5.
    Sử dụng phương thức InSao để in ra số lượng sao theo yêu cầu.
*/

// Input: số lượng sao muốn in ra, mặc định là 5
Console.Write("Nhập vào số lượng sao muốn in ra (mặc định là 5): ");
int n = Convert.ToInt32(Console.ReadLine());

// Output: in ra số lượng sao theo yêu cầu
string result = "";
// Process: Gọi phương thức InSao để in ra số lượng sao theo yêu cầu
result = Method.InSao(n); // Gọi phương thức InSao để in ra số lượng sao theo yêu cầu
Console.WriteLine($"{result}"); 
#endregion

#region Kiểm tra số nguyên tố
/*
    Viết chương trình nhập vào số nguyên dương n, kiểm tra xem số đó có phải là số nguyên tố không.
    Sử dụng phương thức ktSoNguyenTo để kiểm tra số nguyên tố.
*/

// Input: số nguyên dương n
Console.Write("Nhập vào một số nguyên dương: ");
n = Convert.ToInt32(Console.ReadLine());

// Output: kiểm tra xem số đó có phải là số nguyên tố không
bool isPrime = Method.ktSoNguyenTo(n); // Gọi phương thức ktSoNguyenTo để kiểm tra số nguyên tố
Console.WriteLine($"{n} {(isPrime ? "là" : "không phải")} số nguyên tố.");
#endregion

#region Hàm demo
/*
    Viết chương trình nhập vào số nguyên dương n, gán giá trị 20 cho n và in ra giá trị của n.
    Sử dụng phương thức hamDemo để gán giá trị 20 cho n.
*/

// ref là từ khóa dùng để truyền tham chiếu, cho phép phương thức có thể thay đổi giá trị của biến được truyền vào.

n = 10; // Khai báo biến a và gán giá trị 10

int kq = Method.hamDemo(ref n); // Gọi phương thức hamDemo để gán giá trị 20 cho n
Console.WriteLine($"Giá trị của n sau khi gọi phương thức hamDemo: {n}"); // In ra giá trị của n sau khi gọi phương thức hamDemo
#endregion

#region Nhập thông tin
/*
    Viết chương trình nhập vào thông tin người dùng (họ tên, email, số điện thoại).
    Sử dụng phương thức nhapThongTin để nhập thông tin.
*/

// Input: họ tên, email, số điện thoại
string hoTen = "";
string email = "";
string soDT = "";

Method.nhapThongTin(ref hoTen, ref email, ref soDT); // Gọi phương thức nhapThongTin để nhập thông tin
Console.WriteLine($"Họ tên: {hoTen}\nEmail: {email}\nSố điện thoại: {soDT}"); // In ra thông tin người dùng
#endregion

#region Nhập thông tin dạng out
/*
    Viết chương trình nhập vào thông tin người dùng (họ tên, email, số điện thoại).
    Sử dụng phương thức nhapThongTinOut để nhập thông tin.
*/

/*
    Truyền tham số bình thường gọi là truyền tham trị (pass by value), nghĩa là giá trị của biến được truyền vào phương thức sẽ được sao chép và sử dụng trong phương thức đó. Nếu thay đổi giá trị của biến trong phương thức, giá trị của biến gốc bên ngoài phương thức sẽ không bị ảnh hưởng.
    Truyền tham số bằng từ khóa ref gọi là truyền tham chiếu (pass by reference), nghĩa là phương thức sẽ nhận được địa chỉ của biến được truyền vào, và có thể thay đổi giá trị của biến đó. Nếu thay đổi giá trị của biến trong phương thức, giá trị của biến gốc bên ngoài phương thức cũng sẽ bị thay đổi.
    Truyền tham số bằng từ khóa out cũng gọi là truyền tham chiếu (pass by reference), nhưng khác với ref, biến được truyền vào phương thức phải được khởi tạo trước khi gọi phương thức, và phương thức phải gán giá trị cho biến đó trước khi kết thúc. Nếu không gán giá trị cho biến trong phương thức, sẽ xảy ra lỗi biên dịch.
*/

// Input: họ tên, email, số điện thoại
string hoTenRef = "";
string emailRef = "";
string soDTRef = "";

Method.nhapThongTin(ref hoTenRef, ref emailRef, ref soDTRef); // Gọi phương thức nhapThongTin để nhập thông tin
Method.nhapThongTinOut(out string hoVaTen, out string mail, out string soDienThoai); // Gọi phương thức nhapThongTinOut để nhập thông tin
Console.WriteLine($"Họ tên: {hoVaTen}\nEmail: {mail}\nSố điện thoại: {soDienThoai}"); // In ra thông tin người dùng
#endregion

#region In số nguyên tố
/*
    Viết chương trình cho phép người dùng nhập vào số nguyên n, sau đó in ra các số nguyên tố từ 2 đến n.
    Sử dụng phương thức inDaySoNguyenTo để in ra các số nguyên tố từ 2 đến n.
*/
Console.Write("Nhập vào một số nguyên dương: ");
n = int.Parse(Console.ReadLine() ?? "0"); // Nhập vào số nguyên dương n
Console.WriteLine(Method.inDaySoNguyenTo(n));
#endregion

#region In số nguyên tố trong chuỗi
/*
    Viết chương trình cho phép người dùng nhập vào một chuỗi ví dụ "143244534" in ra những số nguyên tố trong chuỗi đó.
    Sử dụng phương thức inSoNguyenToTrongChuoi để in ra những số nguyên tố trong chuỗi đó.
*/
Console.Write("Nhập vào một chuỗi ký tự: ");
string chuoi = Console.ReadLine() ?? ""; // Nhập vào chuỗi ký tự
Console.WriteLine(Method.inSoNguyenToTrongChuoi(chuoi));
#endregion

#region Đếm độ dài từ cuối cùng
/*
    Viết chương trình cho phép người dùng nhập vào một chuỗi ký tự, sau đó đếm độ dài của từ cuối cùng trong chuỗi đó.
    Sử dụng phương thức demDoDaiTuCuoi để đếm độ dài của từ cuối cùng trong chuỗi đó.
*/
Console.Write("Nhập vào một chuỗi ký tự: ");
string chuoi2 = Console.ReadLine() ?? ""; // Nhập vào chuỗi ký tự
Console.WriteLine(Method.demDoDaiTuCuoiCung(chuoi2));
#endregion
