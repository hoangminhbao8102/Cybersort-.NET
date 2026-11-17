namespace WalletBlazor.Models;

public enum WalletTransactionType
{
    Deposit,
    Withdraw
}

public sealed record WalletTransaction(
    WalletTransactionType Type,
    decimal Amount,
    DateTime CreatedAt);
