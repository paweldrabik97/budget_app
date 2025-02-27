using api.Models;
using System.ComponentModel.DataAnnotations;

namespace api.DTOs.Transaction
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? Comment { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; } = null!;
        public Category? Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
        public User User { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
