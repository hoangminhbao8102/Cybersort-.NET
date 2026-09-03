using System.Text;

/*
Bài tập 9: Chuyển đổi từ km/h sang m/s
Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s theo công thức: m/s = km/h ÷ 3.6. In ra kết quả sau khi chuyển đổi.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào vận tốc bằng km/h: ");
double vanTocKmH = double.Parse(Console.ReadLine() ?? "0");
double vanTocMS = vanTocKmH / 3.6;
Console.WriteLine($"Vận tốc {vanTocKmH} km/h tương đương với {vanTocMS:F2} m/s");
