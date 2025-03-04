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
                CategoryId = transaction.CategoryId,
                Date = transaction.Date,
                UserId = transaction.UserId,
                User = transaction.User.ToDto(),
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
                CategoryId = transactionDto.CategoryId,
                Date = transactionDto.Date,
                UserId = transactionDto.UserId,
                CreatedOn = transactionDto.CreatedOn
            };
        }
    }
}
