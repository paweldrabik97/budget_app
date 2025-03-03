using api.Models;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Transaction
{
    public class UpdateTransactionRequestDto
    {
        public string Description { get; set; } = string.Empty;
        public string? Comment { get; set; }
        public decimal Amount { get; set; }
        public int TypeId { get; set; }
        public TransactionType Type { get; set; } = null!;
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
        public string UserId { get; set; } = string.Empty;
        public User User { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
