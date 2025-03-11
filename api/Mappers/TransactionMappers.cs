using api.DTOs.Transaction;
using api.Models;

namespace api.Mappers
{
    public static class TransactionMappers
    {
        public static TransactionDto ToDto(this Transaction transaction)
        {
            return new TransactionDto
            {
                Id = transaction.Id,
                Description = transaction.Description,
                Comment = transaction.Comment,
                Amount = transaction.Amount,
                TypeId = transaction.TypeId,
                Type = transaction.Type.ToDto(),
                CategoryId = transaction.CategoryId,
                Category = transaction.Category?.ToDto(),
                Date = transaction.Date,
                UserId = transaction.UserId,
                User = transaction.User.ToDto(),
                CreatedOn = transaction.CreatedOn
            };
        }
        public static Transaction ToTransactionFromCreateDto(this CreateTransactionRequestDto transactionDto, string userId)
        {
            return new Transaction
            {
                Description = transactionDto.Description,
                Comment = transactionDto.Comment,
                Amount = transactionDto.Amount,
                TypeId = transactionDto.TypeId,
                CategoryId = transactionDto.CategoryId,
                Date = transactionDto.Date,
                UserId = userId
            };
        }
    }
}
