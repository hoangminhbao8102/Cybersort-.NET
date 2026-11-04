# ResumeBlazor — Bootstrap + Blazor

Bài tập chuyển layout résumé thành các trang riêng bằng **Blazor Web App (.NET 8, Interactive Server)** và **Bootstrap 5.2.3**.

## Chạy dự án

Cài .NET 8 SDK, mở terminal tại thư mục chứa `ResumeBlazor.csproj`:

```bash
dotnet restore
dotnet run
```

Mở **http://localhost:5000**. Trong Visual Studio 2022 có hỗ trợ .NET 8, mở `ResumeBlazor.csproj` và nhấn F5.

## Route

| Đường dẫn | Component |
|---|---|
| `/` | Home: chuyển đến `/about` |
| `/about` | About.razor |
| `/experience` | Experience.razor |
| `/education` | Education.razor |
| `/skills` | Skills.razor |
| `/interests` | Interests.razor |
| `/award`, `/awards` | Award.razor |

Menu dùng đường dẫn chuẩn `/award`; `/awards` là alias để truy cập trực tiếp.

## Cấu trúc và kỹ thuật

- `Components/App.razor`: HTML gốc, CSS và Blazor script.
- `Components/Routes.razor`: Router, RouteView, FocusOnNavigate, trang không tìm thấy khi điều hướng trong Blazor.
- `Components/Pages/_Imports.razor`: **@layout MainLayout** áp dụng chung cho các trang.
- `Components/Layout/MainLayout.razor`: kế thừa LayoutComponentBase; chứa NavMenu và **@Body**.
- `Components/Layout/NavMenu.razor`: NavLink đánh dấu mục đang chọn; menu mobile đóng/mở bằng **@onclick** và biến C#; tự đóng sau khi chọn mục.
- `Components/Shared/ResumeSection.razor`: section dùng lại qua **[Parameter]** và **RenderFragment ChildContent**.
- `Components/Shared/ResumeEntry.razor`: component dùng lại cho Experience và Education.
- `Components/Pages/*.razor`: **@page** khai báo route riêng và PageTitle đặt tiêu đề tab.
- `wwwroot/css/styles.css`: Bootstrap 5.2.3 kèm theme gốc, có lưu bản quyền.
- `wwwroot/css/app.css`: điều chỉnh responsive, focus và trạng thái lỗi Blazor.

Không dùng ScrollSpy hoặc script animation/scroll của mẫu. Bootstrap utilities (`d-flex`, `flex-md-row`, `gap-3`, `mb-5`, ...), navbar và responsive breakpoints được dùng trực tiếp. Không cần Bootstrap JavaScript vì menu được Blazor quản lý.

## Nội dung và tài nguyên

Giữ nội dung Clarence Taylor để đối chiếu với mẫu; thay thông tin cá nhân trong các trang và ảnh tại `wwwroot/assets/img/profile.jpg` khi sử dụng thật. Các nút mạng xã hội dẫn tới trang chủ nền tảng để tránh dùng liên kết giả `#!`; hãy thay bằng hồ sơ cá nhân của bạn.

CSS Bootstrap/theme, ảnh và Font Awesome được đóng gói tại wwwroot. Google Fonts tải qua mạng; nếu không có mạng, trình duyệt dùng font dự phòng. Khi chạy Interactive Server, trình duyệt cần giữ kết nối với ứng dụng ASP.NET Core.

Layout tham khảo: https://bt-component-netcore.cybersoft.edu.vn/
Theme gốc: Start Bootstrap Resume, MIT (xem `THIRD-PARTY-NOTICES.md` và `LICENSE-RESUME.txt`).

## Kiểm tra đã thực hiện

- `dotnet build`: thành công, 0 lỗi, 0 cảnh báo.
- HTTP: 7 đường dẫn nội dung trả về 200, mỗi trang chỉ có một section tương ứng.
- `/` chuyển hướng đến `/about`; CSS, ảnh, Font Awesome và Blazor script trả về 200.
- Chưa xác minh thao tác menu mobile bằng trình duyệt tự động trong môi trường tạo bài.
