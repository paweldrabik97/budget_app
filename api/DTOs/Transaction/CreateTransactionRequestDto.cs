using api.Models;

namespace api.DTOs.Transaction
{
    public class CreateTransactionRequestDto
    {
        public string Description { get; set; } = string.Empty;
        public string? Comment { get; set; }
        public decimal Amount { get; set; }
        public int TypeId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string UserId { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
