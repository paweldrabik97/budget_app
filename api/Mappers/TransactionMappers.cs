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

    }
}
