using System.Text;

/*
Bài tập 7: Tính tốc độ trung bình
Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian đã đi (giờ). Tính và in ra tốc độ trung bình (km/h).
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập quãng đường đã đi (km) : ");
double s = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập thời gian đã đi (giờ) : ");
double t = Convert.ToDouble(Console.ReadLine());
double v = s / t;
Console.WriteLine($"Tốc độ trung bình là {v} km/h.");
