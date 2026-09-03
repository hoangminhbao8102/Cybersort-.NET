using System.Text;

/*
Bài tập 2 : Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá 
Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập giá trị đơn hàng: ");
double giaTriDonHang = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Nhập phần trăm giảm giá: ");
double phanTramGiamGia = double.Parse(Console.ReadLine() ?? "0");
double soTienGiamGia = giaTriDonHang * (phanTramGiamGia / 100);
double tongSoTienPhaiThanhToan = giaTriDonHang - soTienGiamGia;
Console.WriteLine("Số tiền giảm giá: {0}", soTienGiamGia);
Console.WriteLine("Tổng số tiền phải thanh toán: {0}", tongSoTienPhaiThanhToan);
