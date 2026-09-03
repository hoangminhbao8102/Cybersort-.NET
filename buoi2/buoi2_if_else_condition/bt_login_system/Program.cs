using System.Text;

/*
Viết chương trình C# để thực hiện cho phép người dùng nhập vào email và password.
Nếu email = "minhbao" và password = "dotnet08" thì in ra "Đăng nhập thành công"
Ngược lại thì in ra "Đăng nhập thất bại"
*/
Console.OutputEncoding = Encoding.UTF8;
// input: email và password
Console.Write("Nhập vào email: ");
string email = Console.ReadLine() ?? "";
Console.Write("Nhập vào password: ");
string password = Console.ReadLine() ?? "";
// output: thông báo đăng nhập thành công/thất bại
string message = "";
// process: kiểm tra điều kiện email và password
if (email == "minhbao" && password == "dotnet08")
{
    message = "Đăng nhập thành công";
}
else
{
    message = "Đăng nhập thất bại";
}
// print result: in ra thông báo
Console.WriteLine(message);
