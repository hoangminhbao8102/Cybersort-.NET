using System.Text;

/*
Bài tập 10: Tính lượng calo tiêu thụ
Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình tập thể dục (chọn từ các giá trị đã định trước như chạy, đạp xe, bơi lội). Tính và in ra lượng calo tiêu thụ dựa trên số phút và loại hình tập thể dục (sử dụng hệ số calo tiêu thụ giả định cho mỗi loại hình).
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào số phút đã tập thể dục: ");
double soPhut = double.Parse(Console.ReadLine() ?? "0");
double heSoCaloChay = 0.05; // calo/phút cho chạy
double heSoCaloDapXe = 0.08; // calo/phút cho đạp xe
double heSoCaloBoiLoi = 0.1; // calo/phút cho bơi lội

double luongCaloChay = soPhut * heSoCaloChay; // mặc định là chạy
double luongCaloDapXe = soPhut * heSoCaloDapXe; // mặc định là đạp xe
double luongCaloBoiLoi = soPhut * heSoCaloBoiLoi; // mặc định là bơi lội

Console.WriteLine($"Lượng calo tiêu thụ trong {soPhut} phút tập thể dục loại chạy là: {luongCaloChay:F2} calo");
Console.WriteLine($"Lượng calo tiêu thụ trong {soPhut} phút tập thể dục loại đạp xe là: {luongCaloDapXe:F2} calo");
Console.WriteLine($"Lượng calo tiêu thụ trong {soPhut} phút tập thể dục loại bơi lội là: {luongCaloBoiLoi:F2} calo");
