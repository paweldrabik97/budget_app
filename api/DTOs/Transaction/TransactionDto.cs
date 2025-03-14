﻿using api.DTOs.Account;
using api.DTOs.Category;
using api.DTOs.TransactionType;
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
        public int TypeId { get; set; }
        public TransactionTypeDto Type { get; set; } = null!;
        public int? CategoryId { get; set; }
        public CategoryDto? Category { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string UserId { get; set; } = string.Empty;
        public UserDto User { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
