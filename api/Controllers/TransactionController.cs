using api.Data;
using api.DTOs.Transaction;
using api.Interfaces;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ITransactionRepository _transactionRepo;

        public TransactionController(ApplicationDbContext context, ITransactionRepository transactionRepo)
        {
            _context = context;
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions()
        {
            var transactions = await _transactionRepo.GetTransactionsAsync();

            return Ok(transactions);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransaction([FromRoute] int id)
        {
            var transaction = await _transactionRepo.GetTransactionByIdAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction.ToDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTransactionRequestDto transactionDto)
        {
            var transaction = transactionDto.ToTransactionFromCreateDto();
            await _transactionRepo.CreateTransactionAsync(transaction);
            return CreatedAtAction(nameof(GetTransaction), new { id = transaction.Id }, transaction);
        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdateTransactionRequestDto transactionDto)
        {
            var transaction = _transactionRepo.UpdateTransactionAsync(id, transactionDto);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var transaction = await _transactionRepo.DeleteTransactionAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }

}
