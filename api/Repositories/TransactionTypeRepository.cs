using api.Data;
using api.DTOs.TransactionType;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class TransactionTypeRepository : ITransactionTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public TransactionTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TransactionType> CreateTransactionTypeAsync(TransactionType transactionTypeModel)
        {
            await _context.TransactionTypes.AddAsync(transactionTypeModel);
            await _context.SaveChangesAsync();
            return transactionTypeModel;
        }

        public async Task<TransactionType?> DeleteTransactionTypeAsync(int id)
        {
            var transactionType = await _context.TransactionTypes.FirstOrDefaultAsync(t => t.Id == id);
            if (transactionType == null)
            {
                return null;
            }
            _context.TransactionTypes.Remove(transactionType);
            await _context.SaveChangesAsync();
            return transactionType;
        }

        public async Task<TransactionType?> GetTransactionTypeByIdAsync(int id)
        {
            return await _context.TransactionTypes.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<TransactionTypeDto>> GetTransactionTypesAsync()
        {
            return await _context.TransactionTypes.Select(t => t.ToDto()).ToListAsync();
        }

        public async Task<TransactionType?> UpdateTransactionTypeAsync(int id, UpdateTransactionTypeRequestDto transactionTypeDto)
        {
            var existingTransactionType = await _context.TransactionTypes.FirstOrDefaultAsync(t => t.Id == id);
            if (existingTransactionType == null)
            {
                return null;
            }

            existingTransactionType.Type = transactionTypeDto.Type;
            await _context.SaveChangesAsync();
            return existingTransactionType;
        }
    }
}
