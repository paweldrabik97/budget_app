using api.Data;
using api.DTOs.Transaction;
using api.Interfaces;
using api.Mappers;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;
        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Transaction> CreateTransactionAsync(Transaction transactionModel)
        {
            await _context.Transactions.AddAsync(transactionModel);
            await _context.SaveChangesAsync();
            return transactionModel;
        }

        public async Task<Transaction?> DeleteTransactionAsync(int id)
        {
            var transaction = await _context.Transactions.FirstOrDefaultAsync(t => t.Id == id);

            if (transaction == null)
            {
                return null;
            }

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<Transaction?> GetTransactionByIdAsync(int id)
        {
            return await _context.Transactions.Include(t => t.User).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<TransactionDto>> GetTransactionsAsync()
        {
            return await _context.Transactions.Include(t => t.User).Select(t => t.ToDto()).ToListAsync();
        }

        public async Task<Transaction?> UpdateTransactionAsync(int id, UpdateTransactionRequestDto transactionDto)
        {
            var existingTransaction = await _context.Transactions.FirstOrDefaultAsync(t => t.Id == id);

            if (existingTransaction == null)
            {
                return null;
            }

            existingTransaction.Description = transactionDto.Description;
            existingTransaction.Comment = transactionDto.Comment;
            existingTransaction.Amount = transactionDto.Amount;
            existingTransaction.TypeId = transactionDto.TypeId;
            existingTransaction.CategoryId = transactionDto.CategoryId;
            existingTransaction.Date = transactionDto.Date;
            existingTransaction.UserId = transactionDto.UserId;
            existingTransaction.CreatedOn = transactionDto.CreatedOn;

            await _context.SaveChangesAsync();

            return existingTransaction;
        }

        public Task<bool> UserExists(string userId)
        {
            return _context.Users.AnyAsync(u => u.Id == userId);
        }
    }
}
