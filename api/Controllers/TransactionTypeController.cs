using api.DTOs.TransactionType;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionTypeController : ControllerBase
    {
        private readonly ITransactionTypeRepository _transactionTypeRepo;
        public TransactionTypeController(ITransactionTypeRepository transactionTypeRepo)
        {
            _transactionTypeRepo = transactionTypeRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetTransactionTypes()
        {
            var transactionTypes = await _transactionTypeRepo.GetTransactionTypesAsync();
            return Ok(transactionTypes);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionTypeById([FromRoute] int id)
        {
            var transactionType = await _transactionTypeRepo.GetTransactionTypeByIdAsync(id);
            if (transactionType == null)
            {
                return NotFound();
            }
            return Ok(transactionType.ToDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTransactionTypeRequestDto transactionTypeDto)
        {
            var transactionType = transactionTypeDto.ToTransactionTypeFromCreateDto();
            await _transactionTypeRepo.CreateTransactionTypeAsync(transactionType);
            return CreatedAtAction(nameof(GetTransactionTypeById), new { id = transactionType.Id }, transactionType.ToDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateTransactionTypeRequestDto transactionTypeDto)
        {
            var transactionType = await _transactionTypeRepo.UpdateTransactionTypeAsync(id, transactionTypeDto);
            if (transactionType == null)
            {
                return NotFound();
            }
            return Ok(transactionType.ToDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var transactionType = await _transactionTypeRepo.DeleteTransactionTypeAsync(id);
            if (transactionType == null)
            {
                return NotFound();
            }
            return Ok(transactionType.ToDto());
        }
    }
}
