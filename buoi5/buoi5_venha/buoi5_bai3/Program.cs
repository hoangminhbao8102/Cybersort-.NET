using System;

/*
    Đề bài: Cho một chuỗi s chứa các từ cách nhau bởi khoảng trắng, trong đó có các từ chứa cả chữ cái và chữ số. Viết hàm trả về từ dài nhất có chứa ít nhất một số. Nếu không có từ nào chứa số, trả về chuỗi rỗng.
    Ví dụ:
    Input: "abc123 def45 ghi6789"
    Output: "ghi6789"
*/
Console.Write("Nhập chuỗi: ");
string input = Console.ReadLine() ?? string.Empty;
string longestWord = Method.LongestWordWithNumber(input);
Console.WriteLine($"Từ dài nhất chứa ít nhất một số: {longestWord}");
