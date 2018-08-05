using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Category;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Tag;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class TagController : GoogleController
    {
        private readonly ITagService _tagService;

        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _tagService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(TagDto dto)
        {
            await _tagService.AddAsync(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _tagService.RemoveAsync(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(TagDto dto)
        {
            await _tagService.UpdateAsync(dto);
            return Ok();
        }

        [HttpGet("query")]
        public async Task<IActionResult> Query(int take = 20, int skip = 0)
        {
            return Ok();
        }
    }
}