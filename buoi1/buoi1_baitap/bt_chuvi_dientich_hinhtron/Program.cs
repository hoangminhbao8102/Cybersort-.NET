using System.Text;

/*
 * Bài tập 2: Viết chương trình nhập vào bán kính hình tròn và in ra chu vi và diện tích hình tròn
 * Công thức tính chu vi hình tròn: C = 2 * π * r
 * Công thức tính diện tích hình tròn: S = π * r^2
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Bạn nhập bán kính hình tròn: ");
double r = Convert.ToDouble(Console.ReadLine());
double chuVi = 2 * Math.PI * r;
double dienTich = Math.PI * Math.Pow(r, 2);
Console.WriteLine($"Chu vi hình tròn: {chuVi}");
Console.WriteLine($"Diện tích hình tròn: {dienTich}");
