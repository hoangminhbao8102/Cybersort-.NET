public class Method
{
    /*
        Đề bài: Viết một hàm nhận vào một chuỗi s, trả về từ dài nhất trong chuỗi đó. Nếu có nhiều từ có độ dài bằng nhau, trả về từ đầu tiên tìm thấy.
        Ví dụ:
        Input: "I love programming"
        Output: "programming"
    */
    public static string LongestWord(string s)
    {
        // Tách chuỗi thành các từ
        string[] words = s.Split(' ');

        // Khởi tạo biến để lưu từ dài nhất
        string longestWord = "";

        // Duyệt qua từng từ trong mảng
        for(int i = 0; i < words.Length; i++)
        {
            // Nếu từ hiện tại dài hơn từ dài nhất đã tìm được
            if (words[i].Length > longestWord.Length)
            {
                // Cập nhật từ dài nhất
                longestWord = words[i];
            }
        }

        // Trả về từ dài nhất tìm được
        return longestWord;
    }
}