using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// Phép tính so sánh: > < >= <= == !=
int a = 5;
int b = 7;
int c = 5;

Console.WriteLine("So sánh a > b: " + (a > b)); // 5 > 7: false
Console.WriteLine("So sánh a < b: " + (a < b)); // 5 < 7: true
Console.WriteLine("So sánh a >= b: " + (a >= b)); // 5 >= 7: false
Console.WriteLine("So sánh a <= c: " + (a <= c)); // 5 <= 5: true
Console.WriteLine("So sánh a == c: " + (a == c)); // 5 == 5: true
Console.WriteLine("So sánh a != c: " + (a != c)); // 5 != 5: false

// So sánh kết hợp: && (và: and), || (hoặc: or)
Console.WriteLine("So sánh (a < b) && (a == c): " + ((a < b) && (a == c))); // (5 < 7) && (5 == 5): true
Console.WriteLine("So sánh (a > b) || (a == c): " + ((a > b) || (a == c))); // (5 > 7) || (5 == 5): true

string str1 = "Đẹp trai";
string str2 = "Giỏi";
string str3 = "Giàu";

Console.WriteLine("Phép and (&&): " + (str1 == str3 && str2 == str3)); // ("Đẹp trai" == "Giàu") && ("Giỏi" == "Giàu"): false
Console.WriteLine("Phép or (||): " + (str1 == str3 || str2 == str3)); // ("Đẹp trai" == "Giàu") || ("Giỏi" == "Giàu"): false

// Phép toán logic: ! (not)
Console.WriteLine("Phủ định True: " + (!true)); // !true: false
Console.WriteLine("Phủ định False: " + (!false)); // !false: true

// Kiểu dữ liệu nguyên thủy: int, float, double, decimal, bool, char, string

// bool bb = true; // Kiểu dữ liệu boolean: true hoặc false
