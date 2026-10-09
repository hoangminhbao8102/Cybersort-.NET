using System.Text.Json;

NhanVien nv = new NhanVien();
Console.WriteLine($"Nhân viên: {JsonSerializer.Serialize(nv)}");

SanPham sp = new SanPham();
Console.WriteLine($"Sản phẩm: {JsonSerializer.Serialize(sp)}");

Console.WriteLine("ABCD");

Console.WriteLine($"Dev A push code: {JsonSerializer.Serialize(nv)}");

Console.WriteLine($"Dev B push code: {JsonSerializer.Serialize(sp)}");

Console.WriteLine($"Dev A ok.");