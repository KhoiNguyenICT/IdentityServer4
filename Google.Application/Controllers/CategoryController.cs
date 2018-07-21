using System;
using System.Threading.Tasks;
using Google.Service.Dtos.Category;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class CategoryController : GoogleController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _categoryService.Get(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CategoryDto dto)
        {
            await _categoryService.Add(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _categoryService.Remove(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(CategoryDto dto)
        {
            await _categoryService.Update(dto);
            return Ok();
        }
    }
}