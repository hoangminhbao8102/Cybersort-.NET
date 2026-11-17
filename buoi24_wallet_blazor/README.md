# My Wallet - Bài tập Blazor

Ứng dụng ví tiền viết bằng **Blazor Web App (.NET 8) + Bootstrap 5.3.3**, sử dụng **Interactive Server**.

## Chức năng

- Nạp tiền qua modal (số tiền dương, tối đa 2 chữ số thập phân).
- Rút tiền qua modal, không được vượt quá số dư.
- Cập nhật số dư và thêm giao dịch mới lên đầu lịch sử tức thì.
- Lịch sử có loại giao dịch, số tiền và thời gian giao dịch.
- Modal có 2 chế độ `Deposit Money` và `Withdraw Money`.

## Cách chạy

1. Cài Visual Studio 2022 (ASP.NET and web development) và .NET 8 SDK.
2. Mở `WalletBlazor.csproj`.
3. Bấm **F5** hoặc chạy:
   ```sh
   dotnet restore
   dotnet run --launch-profile http
   ```
4. Mở `http://localhost:5087/` (hoặc `/wallet`).

Không dùng NuGet package ngoài; Bootstrap được gọi qua CDN. CSS bổ sung ở `wwwroot/css/app.css`.

## Tổ chức components và state

- `Components/Pages/MyWallet.razor`: trang ví, giữ `decimal _balance`, `List<WalletTransaction> _transactions`, `WalletTransactionType? _activeAction`; xử lý cộng/trừ tiền.
- `Components/Shared/ModalWallet.razor`: form dùng chung cho nạp/rút, giữ `_amountText` và `_error`; truyền số tiền lên cha bằng `EventCallback<decimal>`.
- `Models/WalletTransaction.cs`: loại giao dịch, số tiền và thời gian.

## Lưu ý

- Số dư mặc định **$2499.73**, lịch sử 4 giao dịch là **dữ liệu minh họa** theo đề bài.
- Dữ liệu lưu trong bộ nhớ component. Refresh trang sẽ về dữ liệu mẫu, chưa dùng database/localStorage. Đây là bài tập UI/state, không phải ví tiền thật.
