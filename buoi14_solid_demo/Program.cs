// Khái niệm về Generic trong C# là một cách để định nghĩa các lớp, phương thức, hoặc giao diện mà có thể hoạt động với nhiều loại dữ liệu khác nhau mà không cần phải viết lại mã cho từng loại dữ liệu cụ thể. Generic giúp tăng tính tái sử dụng của mã và giảm sự trùng lặp.
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Solid.I;

App<Product> appProduct = new App<Product>(); // App product
Product prod = new Product();
appProduct.AddNewItem(prod);
appProduct.RemoveItem(prod.Id);

App<User> appUser = new App<User>(); // App user
User user = new User();
appUser.AddNewItem(user);
appUser.RemoveItem(user.Id);

// Activator function: Activator là một lớp trong .NET Framework cung cấp các phương thức để tạo các đối tượng tại runtime. Nó cho phép bạn tạo các thể hiện của các lớp mà không cần biết trước loại cụ thể của chúng, điều này rất hữu ích khi làm việc với reflection hoặc khi bạn muốn tạo các đối tượng dựa trên thông tin runtime.
Product prod1 = new Product();
prod1.Id = 1;
prod1.Name = "Product 1";
prod1.Price = 10.0;
prod1.Description = "Description for Product 1";

Console.WriteLine($"{JsonSerializer.Serialize(prod1)}");
// Khởi tạo một đối tượng Product mới bằng cách sử dụng Activator.CreateInstance
Type productType = typeof(Product);
dynamic newItem = Activator.CreateInstance(productType) ?? throw new InvalidOperationException("Unable to create Product instance.");
Console.WriteLine($"{JsonSerializer.Serialize(newItem)}");

// Khởi tạo có tham số
Product prod2 = new Product(2, "Product 2", 10.0, "Description for Product 2");
Console.WriteLine($"{JsonSerializer.Serialize(prod2)}");

dynamic prod3 = Activator.CreateInstance(productType, 3, "Product 3", 10.0, "Description for Product 3") ?? throw new InvalidOperationException("Unable to create Product instance.");
Console.WriteLine($"{JsonSerializer.Serialize(prod3)}");

dynamic prod4 = Activator.CreateInstance(productType, new object[] { 4, "Product 4", 20.0, "Description for Product 4" }) ?? throw new InvalidOperationException("Unable to create Product instance.");
Console.WriteLine($"{JsonSerializer.Serialize(prod4)}");

NhanVien nhanVien = new NhanVien(1, "Nguyen Van A", "Developer", 1000.0, 40.0);

NhanVienServices nhanVienServices = new NhanVienServices();
nhanVienServices.HienThiThongTinServices.DisplayEmployeeInfo(nhanVien);

NhanVienServiceClone nhanVienServiceClone = new NhanVienServiceClone();
nhanVienServiceClone.DisplayEmployeeInfo(nhanVien);

// Giả sử 1 khách hàng bỏ tiền ra thuê dịch vụ cho nhân viên của họ
HoaDon hd1 = new HoaDon()
{
    DichVu = "Ăn uống",
    SoLuong = 20,
    DonGia = 100.0
};
HoaDon hd2 = new HoaDon()
{
    DichVu = "Thuê phòng",
    SoLuong = 10,
    DonGia = 200.0
};

KhachHang kh = new KhachHang("Nguyen Van A");
kh.Id = 1;
kh.lstHoaDon.Add(hd1);
kh.lstHoaDon.Add(hd2);

HoaDonService hdService = new HoaDonService(kh);
hdService.TinhTongTienHoaDon(); // Gọi phương thức để tính tổng tiền hóa đơn và hiển thị thông tin khách hàng cùng tổng tiền.

DIContainer diService = new DIContainer();
 
diService.Register<HoaDon>();
diService.Register<KhachHang>();
diService.Register<HoaDonService>();

hd1 = diService.Resolve<HoaDon>();
kh = diService.Resolve<KhachHang>();
hdService = diService.Resolve<HoaDonService>();

Console.WriteLine($@"{JsonSerializer.Serialize(hd1)}");
Console.WriteLine($@"{JsonSerializer.Serialize(kh)}");
Console.WriteLine($@"{JsonSerializer.Serialize(hdService.ThongTinKhachHang)}");

// Cách 2: Sử dụng thư viện Microsoft.Extensions.DependencyInjection để quản lý DI
var service = new ServiceCollection();

service.AddScoped<HoaDon>();
service.AddScoped<KhachHang>(_ => new KhachHang("Nguyen Van A"));
service.AddScoped<HoaDonService>();

var serviceProvider = service.BuildServiceProvider();

hdService = serviceProvider.GetRequiredService<HoaDonService>();

Console.WriteLine($@"Khách hàng: {JsonSerializer.Serialize(hdService.ThongTinKhachHang)}");