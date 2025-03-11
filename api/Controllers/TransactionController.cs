using api.Data;
using api.DTOs.Transaction;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _transactionRepo;

        public TransactionController(ITransactionRepository transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions()
        {
            var transactions = await _transactionRepo.GetTransactionsAsync();

            return Ok(transactions);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionById([FromRoute] int id)
        {
            var transaction = await _transactionRepo.GetTransactionByIdAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction.ToDto());
        }

        [HttpPost("{userId}")]
        public async Task<IActionResult> Create([FromBody] string userId, CreateTransactionRequestDto transactionDto)
        {
            if (!await _transactionRepo.UserExists(userId))
            {
                return BadRequest("User does not exist!");
            }
            var transaction = transactionDto.ToTransactionFromCreateDto(userId);
            await _transactionRepo.CreateTransactionAsync(transaction);
            return CreatedAtAction(nameof(GetTransactionById), new { id = transaction.Id }, transaction.ToDto());
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
