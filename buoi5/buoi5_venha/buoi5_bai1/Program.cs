using System;

/*
    Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng nhau, trả về từ đầu tiên tìm thấy.
    Ví dụ:
    Input: "I love programming"
    Output: "programming"
*/

Console.Write("Nhập vào một chuỗi: ");
string input = Console.ReadLine() ?? ""; // Sử dụng null-coalescing operator để tránh lỗi nếu input là null

string longestWord = Method.LongestWord(input);
Console.WriteLine($"Từ dài nhất trong chuỗi là: {longestWord}");
