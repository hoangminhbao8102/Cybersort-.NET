# Course Registration Form — Blazor Web App (.NET 8)

Đã sửa lỗi giao diện không có CSS. **Toàn bộ CSS nằm ở `wwwroot/css/app.css`**, được nạp trực tiếp trong `Components/App.razor`:

```html
<link rel="stylesheet" href="css/app.css" />
```

Vì vậy dự án **không phụ thuộc** vào file `CourseRegistrationForm.styles.css` hoặc CSS isolation (`Home.razor.css`).

## Chạy trong Visual Studio 2022

1. Cài **.NET 8 SDK** và workload **ASP.NET and web development**.
2. Giải nén ZIP, mở `CourseRegistrationForm.csproj`.
3. Chạy bằng **F5** hoặc **Ctrl+F5**.
4. Truy cập `/` hoặc `/course-registration`.
5. Nếu trình duyệt còn giao diện cũ, bấm **Ctrl+F5** để tải lại CSS.

## Chép sang project Blazor của bạn

- Chép `Models/CourseRegistrationModel.cs` vào thư mục `Models` và chỉnh namespace.
- Chép `Components/Pages/Home.razor` vào thư mục `Components/Pages` (hoặc đổi tên component). Chỉnh `@using` trong trang.
- **Quan trọng:** chép CSS từ `wwwroot/css/app.css` vào `wwwroot/css/app.css` hiện tại; nếu đã có CSS, bạn có thể *nối thêm* các quy tắc `.registration-card` thay vì ghi đè.
- Kiểm tra `Components/App.razor` có `<link rel="stylesheet" href="css/app.css" />` trong `<head>`.
- Đảm bảo `@rendermode InteractiveServer` trên trang, trong `Program.cs` có `.AddInteractiveServerComponents()` và `.AddInteractiveServerRenderMode()`.

## Chức năng

- Họ tên bắt buộc, tối thiểu 3 ký tự
- Email bắt buộc, đúng định dạng
- Điện thoại bắt buộc, 10–12 chữ số
- Khóa học bắt buộc và không được giữ `Choose...`
- Hình thức Online/Offline bắt buộc
- Ngày bắt đầu bắt buộc
- Ghi chú tùy chọn
- Checkbox điều khoản phải được chọn
- Chỉ hiện thông báo thành công khi dữ liệu hợp lệ

Dữ liệu chỉ được kiểm tra và hiển thị trong ứng dụng, chưa lưu vào CSDL.
