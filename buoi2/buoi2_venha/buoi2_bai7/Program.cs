using System.Text;

/*
🎬 Tình huống – “Hệ thống đặt vé rạp chiếu phim”
Bạn đang phát triển một ứng dụng đặt vé xem phim online. Khi người dùng chọn hạng vé (Standard, Premium, VIP), hệ thống sẽ hiển thị thông tin về tiện ích mà họ nhận được kèm theo vé.
- Standard : Ghế ngồi thường, không có đồ uống
- Premium : Ghế ngồi thoải mái, có đồ uống miễn phí
- VIP : Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Chọn hạng vé (Standard, Premium, VIP): ");
string ticketClass = Console.ReadLine()?.ToLower() ?? "";

switch (ticketClass)
{
    case "standard":
        Console.WriteLine("- Ghế ngồi thường");
        Console.WriteLine("- Không có đồ uống");
        break;
    case "premium":
        Console.WriteLine("- Ghế ngồi thoải mái");
        Console.WriteLine("- Có đồ uống miễn phí");
        break;
    case "vip":
        Console.WriteLine("- Ghế ngồi hạng sang");
        Console.WriteLine("- Có đồ uống và bỏng ngô miễn phí");
        break;
    default:
        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
        break;
}
