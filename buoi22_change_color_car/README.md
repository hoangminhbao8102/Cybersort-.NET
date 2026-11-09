# ChangeColorCar — Blazor Data Binding (.NET 10)

## Chạy ứng dụng

1. Mở thư mục chứa `buoi22_change_color_car.csproj` trong Visual Studio hoặc Terminal.
2. Chạy `dotnet restore` và `dotnet run`.
3. Truy cập `/change-color-car` trên cổng mà ứng dụng hiển thị.

## Cách sửa giao diện so với phiên bản trước

- Toàn bộ CSS của ví dụ được viết trực tiếp trong `Components/Pages/ChangeColorCar.razor` để vẫn có hiệu lực khi CSS isolation chưa được tải.
- Ảnh hiển thị 348 × 197 px.
- Sử dụng CSS Flexbox để đặt ảnh và 3 nút cùng hàng.
- Các màu nút được thiết lập với CSS.
- Nhấn nút sẽ thay đổi state `SelectedColor` và thuộc tính `src` của ảnh.

## Resource

- `wwwroot/products/black-car.jpg`
- `wwwroot/products/red-car.jpg`
- `wwwroot/products/silver-car.jpg`
- Các resource gốc khác vẫn giữ nguyên trong thư mục `wwwroot`.

Lưu ý: Ảnh tĩnh truy cập từ URL bắt đầu bằng `/` thay cho `/wwwroot/`.
