/*
    Viết chương trình cho pháp người dùng nhập vào 1 chuỗi in ra đảo ngược
    string input = "Hello CyberSoft"
    index: 
    input[0] = H
    input[1] = H
    input[2] = H
    ...
    input[Length-1] = t
    .Length: 15
*/
Console.Write("Nhập vào: ");
string input = Console.ReadLine() ?? "";
string reversed = "";

for (int index = input.Length - 1; index >= 0; index--)
{
    reversed += input[index];
}

Console.WriteLine("In ra: " + reversed);
