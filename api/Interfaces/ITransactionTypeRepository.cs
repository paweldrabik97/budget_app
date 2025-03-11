using api.DTOs.TransactionType;
using api.Models;

namespace api.Interfaces
{
    public interface ITransactionTypeRepository
    {
        Task<List<TransactionTypeDto>> GetTransactionTypesAsync();
        Task<TransactionType?> GetTransactionTypeByIdAsync(int id);
        Task<TransactionType> CreateTransactionTypeAsync(TransactionType transactionTypeModel);
        Task<TransactionType?> UpdateTransactionTypeAsync(int id, UpdateTransactionTypeRequestDto transactionTypeDto);
        Task<TransactionType?> DeleteTransactionTypeAsync(int id);
    }
}
