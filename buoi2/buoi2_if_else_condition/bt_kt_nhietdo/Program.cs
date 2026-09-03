using System.Text;

/*
Viết chương trình C# để thực hiện cho phép người dùng nhập vào nhiệt độ t.
Nếu t < 25 thì in ra "Tắt điều hòa"
Ngược lại nếu t >= 25 thì in ra "Mở điều hòa"
*/
Console.OutputEncoding = Encoding.UTF8;
// input: nhiệt độ t
Console.Write("Nhập vào nhiệt độ: ");
double t = double.Parse(Console.ReadLine() ?? "0");
// output: thông báo mở/tắt điều hòa
string message = "";
// process: kiểm tra điều kiện t < 25 hay t >= 25
if (t < 25)
{
    message = "Tắt điều hòa";
}
else
{
    message = "Mở điều hòa";
}
// print result: in ra thông báo
Console.WriteLine(message);
