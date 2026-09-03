using System.Text;

Console.OutputEncoding = Encoding.UTF8;
// input: tuổi = interger
Console.Write("Nhập tuổi: ");
int tuoi = int.Parse(Console.ReadLine() ?? "0");
// output: kết luận = string
string ketluan = "";
// porcess: if tuổi < 0 => kết luận = "Tuổi không hợp lệ!"
if (tuoi < 0)
{
    ketluan = "Tuổi không hợp lệ!";
}
else if (tuoi < 18)
{
    ketluan = "Bạn còn là thiếu niên.";
}
else
{
    ketluan = "Bạn đã trưởng thành.";
}
// in ra màn hình kết luận
Console.WriteLine(ketluan);
