using System.Text;

public class Method
{
    /*
        Đề bài: Cho một chuỗi s chứa các từ và ký tự đặc biệt, hãy loại bỏ tất cả các ký tự đặc biệt và trả về chuỗi chỉ chứa các từ và khoảng trắng. 
        Ví dụ:
        Input: "he@llo! worl#d"
        Output: "hello world"
    */
    public static string RemoveSpecialCharacters(string input)
    {
        // Sử dụng LINQ để lọc các ký tự không phải là chữ cái, số hoặc khoảng trắng
        var result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}
