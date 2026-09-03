/*
Viết chương trình cho phép người dùng nhập vào n (ứng với số dòng) in ra ma trận sao tương ứng
Ví dụ: n = 5
*
**
***
****
*****
*/

// Input: số hàng (int)
Console.Write("Nhập vào n: ");
int n = Convert.ToInt16(Console.ReadLine()); // 5
// Output: kết quả (int)
string result = "";
// Process:
for (int i = 1; i <= n; i++) // i = 1, 2, 3, 4
{
    // Khối lệnh xử lý
    // In i ngôi sao
    for (int j = 1; j <= i; j++)
    {
        result += "*";
    }
    result += "\n";
}
Console.WriteLine(result);
