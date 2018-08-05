using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Common.Extensions;
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
            var result = await _categoryService.GetAsync(id);
            return Ok(result);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> Get()
        {
            var result = await _categoryService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("getTree")]
        public async Task<IActionResult> GetTree()
        {
            var result = await _categoryService.GetTreeCategoryAsync();
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]CategoryDto dto)
        {
            await _categoryService.AddAsync(dto);
            return Ok();
        }

        [HttpPut("updateParent")]
        public async Task<IActionResult> UpdateParent([FromBody]CategoryUpdateParentDto categoryUpdateParentDto)
        {
            await _categoryService.UpdateParentAsync(categoryUpdateParentDto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _categoryService.RemoveAsync(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(CategoryDto dto)
        {
            await _categoryService.UpdateAsync(dto);
            return Ok();
        }

        [HttpGet("query")]
        public async Task<IActionResult> Query(int take = 20, int skip = 0)
        {
            return Ok();
        }
    }
}