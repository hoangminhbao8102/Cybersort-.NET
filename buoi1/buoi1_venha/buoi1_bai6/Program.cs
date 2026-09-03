using System.Text;

/*
Bài tập 6: Tính số dư sau khi rút tiền từ tài khoản
Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số tiền còn dư tài khoản hiện tại: ");
double soDu = Convert.ToDouble(Console.ReadLine());
Console.Write("Nhập số tiền muốn rút: ");
double soTienRut = Convert.ToDouble(Console.ReadLine());
double soDuConLai = soDu - soTienRut;
Console.WriteLine($"Số tiền sau khi rút là {soDuConLai}");
