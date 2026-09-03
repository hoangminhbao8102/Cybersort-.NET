using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, C#");

// Chuỗi (string), số (number) (int: số nguyên (ví dụ: 1, 2, 3), double: số thực, float: số thực đơn)

#region Lệnh nhập xuất

// Lệnh nhập
Console.Write("Nhập tên của bạn: ");
string? name = Console.ReadLine();
Console.WriteLine("Xin chào, " + name + "!");
Console.WriteLine($"Tên của bạn là: {name}");

#endregion

string? email = "baoa@email.com"; // Chuỗi : string
double? price = 1000.5; // Số thực: double
int? salary = 20; // Số nguyên: interger

Console.WriteLine($"Email: {email}");
Console.WriteLine($"Giá: {price}");
Console.WriteLine($"Lương: {salary}");

/*
    Toán tử số học: +, -, *, /, %
    Toán tử so sánh: ==, !=, >, <, >=, <=
    Toán tử logic: &&, ||, !
    Toán tử gán: =, +=, -=, *=, /=, %=
    Toán tử tăng giảm: ++, --
*/

int a = 7;
int b = 5;
int tong = a + b;
int hieu = a - b;
int tich = a * b;
double thuong = (double)a / b; // Ép kiểu (casting) từ int sang double để tránh mất dữ liệu khi chia
int du = a % b; // Phần dư của phép chia
Console.WriteLine($"Tổng của {a} và {b} là: {tong}");
Console.WriteLine($"Hiệu của {a} và {b} là: {hieu}");
Console.WriteLine($"Tích của {a} và {b} là: {tich}");
Console.WriteLine($"Thương của {a} và {b} là: {thuong}");
Console.WriteLine($"Phần dư của {a} và {b} là: {du}");

int c = 10;
++c; // Tiền tố (pre-increment): tăng giá trị của c lên 1 trước khi sử dụng
c++; // Hậu tố (post-increment): tăng giá trị của c lên 1

double d = 10;
Console.WriteLine($"Giá trị của d là: {d++}");
Console.WriteLine($"Giá trị của d là: {(double)d}");

d -= 5; // Giảm giá trị của d xuống 5
Console.WriteLine($"Giá trị của d sau khi giảm 5 là: {(double)d}");

d += 5; // Tăng giá trị của d lên 5
Console.WriteLine($"Giá trị của d sau khi tăng 5 là: {(double)d}");

d *= 5; // Nhân giá trị của d với 5
Console.WriteLine($"Giá trị của d sau khi nhân với 5 là: {(double)d}");

d /= 5; // Chia giá trị của d cho 5
Console.WriteLine($"Giá trị của d sau khi chia cho 5 là: {(double)d}");

/*
    Chuyển đổi kiểu dữ liệu (type casting):
    - Ép kiểu ngầm định (implicit casting): từ kiểu dữ liệu nhỏ hơn sang kiểu dữ liệu lớn hơn (ví dụ: int -> double)
    - Ép kiểu tường minh (explicit casting): từ kiểu dữ liệu lớn hơn sang kiểu dữ liệu nhỏ hơn (ví dụ: double -> int)
    - Sử dụng phương thức Convert: Convert.ToInt32(), Convert.ToDouble(), Convert.ToString(), ...
*/

int e = 10;
double f = e * 0.5; // Ép kiểu ngầm định từ int sang double
Console.WriteLine($"Giá trị của f là: {f}");

double g = 3349358359520502208;
int h = (int)g; // Ép kiểu tường minh từ double sang int
Console.WriteLine($"Giá trị của h là: {h}"); // Kết quả sẽ bị mất dữ liệu do giá trị của g quá lớn so với kiểu int

// Lưu ý: Khi ép kiểu tường minh từ double sang int, phần thập phân sẽ bị loại bỏ và chỉ giữ lại phần nguyên. Nếu giá trị của double quá lớn hoặc quá nhỏ so với phạm vi của int, kết quả sẽ không chính xác.

string? i = "9000000";
// Chuyển đổi từ chuỗi sang số thực (double) và nhân với 2
double? j = Convert.ToDouble(i) * 2; 
Console.WriteLine($"Giá trị của j là: {j}"); // Kết quả sẽ là 18000000
