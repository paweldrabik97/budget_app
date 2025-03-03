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
                Type = transaction.Type,
                Category = transaction.Category,
                Date = transaction.Date,
                User = transaction.User,
                CreatedOn = transaction.CreatedOn
            };
        }
        public static Transaction ToTransactionFromCreateDto(this CreateTransactionRequestDto transactionDto)
        {
            return new Transaction
            {
                Description = transactionDto.Description,
                Comment = transactionDto.Comment,
                Amount = transactionDto.Amount,
                TypeId = transactionDto.TypeId,
                Type = transactionDto.Type,
                CategoryId = transactionDto.CategoryId,
                Category = transactionDto.Category,
                Date = transactionDto.Date,
                UserId = transactionDto.UserId,
                User = transactionDto.User,
                CreatedOn = transactionDto.CreatedOn
            };
        }
    }
}
