using System;

/*
    Hàm void là một hàm không trả về giá trị, nó chỉ thực hiện một hành động nào đó.
    Trong C#, bạn có thể sử dụng delegate Action để định nghĩa một hàm void.
    Dưới đây là ví dụ về cách sử dụng Action để tạo một hàm void:
    void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
*/

/*
    Lambda expression là một cách viết ngắn gọn để định nghĩa một hàm ẩn danh (anonymous function) trong C#.
    Cú pháp của lambda expression là:
    (parameters) => expression
*/

// Ví dụ về cách sử dụng lambda expression để định nghĩa một hàm int tính tổng hai số:
Func<int, int, int> fTinhTong = (a, b) => a + b;

// Gọi hàm fTinhTong với tham số 5 và 10
int result = fTinhTong(5, 10);
Console.WriteLine($"Tổng của 5 và 10 là: {result}");

// Sử dụng Action để định nghĩa hàm SayHello
Action<string> SayHello = (name) => Console.WriteLine($"Hello {name}");

// Gọi hàm SayHello với tham số "Bảo"
SayHello("Bảo");

int value = 10;
// Gọi hàm changeValueFunction để thay đổi giá trị của biến value
Method.changeValueFunction(ref value);
Console.WriteLine($"Giá trị của biến value sau khi gọi hàm changeValueFunction là: {value}");

// Khi khai báo function lambda thì nếu thâm hàm chỉ có một tham số thì có thể bỏ qua dấu ngoặc đơn () và nếu hàm chỉ có một câu lệnh thì có thể bỏ qua dấu ngoặc nhọn {}. Ví dụ:
Func<int, int, int> tinhTongAB = (a, b) => a + b; // Hàm tính tổng hai số
Console.WriteLine($"Tổng của 5 và 10 là: {tinhTongAB(5, 10)}");

Method.MainMethod(SayHello); // Truyền hàm SayHello vào MainMethod như một callback function

Method.MainMethod((desc) => 
{
    Console.WriteLine($"Giá trị nhận được từ callback function: {desc}");
}); // Truyền một lambda expression vào MainMethod như một callback function