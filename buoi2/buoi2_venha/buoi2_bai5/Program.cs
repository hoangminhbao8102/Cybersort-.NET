using System.Text;

/*
🔍 Tình huống – “Lọc số đặc biệt cho hệ thống bảo mật”
Bạn đang phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt” – tức là số nguyên tố.
Để đảm bảo tính chính xác, bạn cần viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập vào có phải là số nguyên tố hay không.
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào một số nguyên: ");
int number = int.Parse(Console.ReadLine() ?? "0");

bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

if (isPrime)
{
    Console.WriteLine($"{number} là số nguyên tố");
}
else
{
    Console.WriteLine($"{number} không phải là số nguyên tố");
}
