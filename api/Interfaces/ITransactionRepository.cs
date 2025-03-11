using api.DTOs.Transaction;
using api.Models;

namespace api.Interfaces
{
    public interface ITransactionRepository
    {
        Task<List<TransactionDto>> GetTransactionsAsync();
        Task<Transaction?> GetTransactionByIdAsync(int id);
        Task<Transaction> CreateTransactionAsync(Transaction transactionModel);
        Task<Transaction?> UpdateTransactionAsync(int id, UpdateTransactionRequestDto transactionDto);
        Task<Transaction?> DeleteTransactionAsync(int id);
        Task<bool> UserExists(string userId);
    }
}
