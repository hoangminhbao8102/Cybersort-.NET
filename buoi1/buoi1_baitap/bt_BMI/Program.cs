using System.Text;

/*
 Bài tập 3: Viết chương trình nhập vào cân nặng và chiều cao của một người, sau đó tính và in ra chỉ số BMI (Body Mass Index)
 * Công thức tính BMI: BMI = cân nặng / (chiều cao)^2
 * Ghi chú: cân nặng tính bằng kg, chiều cao tính bằng m
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Bạn nhập cân nặng (kg): ");
double canNang = Convert.ToDouble(Console.ReadLine());
Console.Write("Bạn nhập chiều cao (m): ");
double chieuCao = Convert.ToDouble(Console.ReadLine());
double bmi = canNang / Math.Pow(chieuCao, 2);
Console.WriteLine($"Chỉ số BMI của bạn là: {bmi}");
