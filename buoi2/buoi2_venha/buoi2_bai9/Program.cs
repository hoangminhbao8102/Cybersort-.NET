using System.Text;

/*
🔤 Tình huống – “Phân loại chữ cái: nguyên âm hay phụ âm”
Bạn đang phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em. Khi người dùng nhập vào một ký tự, chương trình sẽ tự động phân loại:
- Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “ ✅ Là nguyên âm”
- Ngược lại → in “ 🔠 Là phụ âm”
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào một ký tự: ");
char character = Console.ReadLine()?.ToLower()[0] ?? '\0';

if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
{
    Console.WriteLine("✅ Là nguyên âm");
}
else
{
    Console.WriteLine("❌ Là phụ âm");
}
