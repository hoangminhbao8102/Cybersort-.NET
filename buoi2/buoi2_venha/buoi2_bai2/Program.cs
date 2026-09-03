using System.Text;

/*
👨‍💼 Tình huống thực tế – "Tính thuế thu nhập cho người đi làm":
Bạn được giao xây dựng một phần mềm nhỏ để hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân cho nhân viên mỗi tháng. 
Kế toán chỉ cần nhập vào số tiền thu nhập hàng tháng, hệ thống sẽ tự động tính toán số thuế phải nộp theo quy định sau:
- Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế
- Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%
- Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%
*/

Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập vào thu nhập hàng tháng (triệu đồng): ");
double income = double.Parse(Console.ReadLine() ?? "0");

double tax = 0;

if (income <= 5)
{
    tax = 0;
}
else if (income <= 10)
{
    tax = income * 0.1;
}
else
{
    tax = income * 0.2;
}

Console.WriteLine($"Số thuế phải nộp: {tax:F2} triệu đồng");
