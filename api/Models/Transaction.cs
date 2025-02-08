using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public string? Comment { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        
        [Required]
        public TransactionType Type { get; set; } = null!;
        
        public Category? Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
        
        [Required]
        public User User { get; set; } = null!;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
