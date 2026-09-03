using System.Text;

/*
✈ Tình huống – “Xác định tiện ích theo loại vé máy bay”
Bạn đang xây dựng một hệ thống đặt vé máy bay online. Khi hành khách chọn loại vé (Economy, Business hoặc First Class), hệ thống cần hiển thị tiện ích tương ứng như sau:
- Economy: Ghế thường
- Business: Ghế rộng
- First Class: Ghế sang trọng
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Chọn loại vé (Economy, Business, First Class): ");
string ticketType = Console.ReadLine()?.ToLower() ?? "";

switch (ticketType)
{
    case "economy":
        Console.WriteLine("✅ Tiện ích: Ghế thường");
        break;
    case "business":
        Console.WriteLine("✅ Tiện ích: Ghế rộng");
        break;
    case "first class":
        Console.WriteLine("✅ Tiện ích: Ghế sang trọng");
        break;
    default:
        Console.WriteLine("❌ Loại vé không hợp lệ. Vui lòng chọn lại.");
        break;
}
