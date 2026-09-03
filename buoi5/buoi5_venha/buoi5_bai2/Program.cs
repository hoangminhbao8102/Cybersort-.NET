using System;

/*
    Đề bài: Cho một chuỗi s chứa các từ và ký tự đặc biệt, hãy loại bỏ tất cả các ký tự đặc biệt và trả về chuỗi chỉ chứa các từ và khoảng trắng. 
    Ví dụ:
    Input: "he@llo! worl#d"
    Output: "hello world"
*/
Console.Write("Nhập vào một chuỗi: ");
string input = Console.ReadLine() ?? ""; // Sử dụng null-coalescing operator để tránh lỗi nếu input là null
string result = Method.RemoveSpecialCharacters(input);
Console.WriteLine($"Chuỗi sau khi loại bỏ ký tự đặc biệt: {result}");
