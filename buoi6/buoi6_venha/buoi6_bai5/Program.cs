/*
    prices = [7, 1, 5, 3, 6, 4]
    Best Time to Buy and sell Stock
    Mô tả: Cho một mảng prices, mỗi phần tử của nó đại diện cho giá cổ phiếu trong một ngày. Bạn chỉ được mua cổ phiếu một lần và bán cổ phiếu một lần. Hãy tìm giá trị lớn nhất bạn có thể có từ việc mua và bán cổ phiếu
    Ví dụ:
    Input: prices = [7, 1, 5, 3, 6, 4]
    Output: 5
    Giải thích: Bạn mua vào ngày thứ 2 (giá 1) và bán vào ngày thứ 5 (giá 6), lãi là 6 - 1 = 5.
*/

int[] prices = { 7, 1, 5, 3, 6, 4 };
int lowestPrice = prices[0];
int maximumProfit = 0;

for (int day = 1; day < prices.Length; day++)
{
    int currentProfit = prices[day] - lowestPrice;
    maximumProfit = Math.Max(maximumProfit, currentProfit);
    lowestPrice = Math.Min(lowestPrice, prices[day]);
}

Console.WriteLine($"Lợi nhuận lớn nhất là: {maximumProfit}");
