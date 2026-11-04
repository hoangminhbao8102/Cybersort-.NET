# ChangeColorCar - Blazor Data Binding

## Yêu cầu
- .NET 8 SDK
- Visual Studio 2022 hoặc Visual Studio Code

## Chạy chương trình
Mở terminal tại thư mục chứa `ChangeColorCar.csproj`, chạy:

```bash
dotnet restore
dotnet run
```

Mở địa chỉ HTTPS/HTTP được hiển thị trong terminal và truy cập:

```text
/change-color-car
```

## Cấu trúc resource
- `wwwroot/products/`: ảnh xe theo màu.
- `wwwroot/icons/`: icon màu được cung cấp kèm bài (để sẵn trong project, có thể dùng làm swatch nếu muốn mở rộng).

## Data Binding và State
- Route: `@page "/change-color-car"`.
- State: `SelectedColor` có kiểu `string`, lưu một trong các giá trị `red`, `silver`, `black`.
- Binding ảnh: thuộc tính `src` của thẻ `img` nhận giá trị từ `CurrentImage`.
- Event binding: `@onclick` gọi các hàm `SelectRed`, `SelectSilver`, `SelectBlack`.
- Khi state thay đổi, Blazor render lại component và ảnh xe được cập nhật.

Các kiểu `boolean`, `number`, `object`, `array` không cần thiết cho yêu cầu hiện tại. Có thể dùng chúng nếu mở rộng, ví dụ `bool IsLoading`, `int SelectedIndex`, một object `Car`, hoặc danh sách `List<CarColor>`.
