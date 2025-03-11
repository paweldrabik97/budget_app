using api.DTOs.Category;
using api.Interfaces;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryRepo.GetCategoriesAsync();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] int id)
        {
            var category = await _categoryRepo.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category.ToDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequestDto categoryDto)
        {
            var category = categoryDto.ToCategoryFromCreateDto();
            await _categoryRepo.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category.ToDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCategoryRequestDto categoryDto)
        {
            var category = await _categoryRepo.UpdateCategoryAsync(id, categoryDto);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category.ToDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var category = await _categoryRepo.DeleteCategoryAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category.ToDto());
        }
    }
}
