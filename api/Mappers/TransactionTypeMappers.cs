using api.DTOs.TransactionType;
using api.Models;

namespace api.Mappers
{
    public static class TransactionTypeMappers
    {
        public static TransactionTypeDto ToDto(this TransactionType transactionType)
        {
            return new TransactionTypeDto
            {
                Id = transactionType.Id,
                Type = transactionType.Type
            };
        }
        public static TransactionType ToTransactionTypeFromCreateDto(this CreateTransactionTypeRequestDto transactionTypeDto)
        {
            return new TransactionType
            {
                Type = transactionTypeDto.Type
            };
        }
    }
}
