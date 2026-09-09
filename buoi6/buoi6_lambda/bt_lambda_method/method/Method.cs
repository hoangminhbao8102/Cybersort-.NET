public class Method
{
    // Khai báo callback delegate
    public delegate void ChangeValueType(ref int value);

    public static ChangeValueType changeValueFunction = (ref int value) =>
    {
        value = 20;
    };

    // Callback function là một hàm được truyền vào như một tham số cho một hàm khác.
    // Trong C#, bạn có thể sử dụng delegate để định nghĩa callback function.
    // Dưới đây là ví dụ về cách sử dụng delegate để định nghĩa một callback function:
    public static void MainMethod(Action<string> ThucHienCongViec)
    {
        string value = "Hello, World!";

        ThucHienCongViec(value);

        Console.WriteLine($"Hoàn thành công việc với giá trị: {value}");
    }
}