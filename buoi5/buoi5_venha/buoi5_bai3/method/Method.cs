public class Method
{
    /*
        Đề bài: Cho một chuỗi s chứa các từ cách nhau bởi khoảng trắng, trong đó có các từ chứa cả chữ cái và chữ số. Viết hàm trả về từ dài nhất có chứa ít nhất một số. Nếu không có từ nào chứa số, trả về chuỗi rỗng.
        Ví dụ:
        Input: "abc123 def45 ghi6789"
        Output: "ghi6789"
    */
    public static string LongestWordWithNumber(string input)
    {
        // Tách chuỗi thành các từ dựa trên khoảng trắng
        var words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string longestWord = string.Empty;

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            // Kiểm tra xem từ có chứa ít nhất một chữ số hay không
            if (word.Any(char.IsDigit))
            {
                // Cập nhật từ dài nhất nếu cần
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
        }

        return longestWord;
    }
}