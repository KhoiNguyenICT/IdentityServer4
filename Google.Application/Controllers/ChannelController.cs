using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Category;
using Google.Service.Dtos.Channel;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class ChannelController : GoogleController
    {
        private readonly IChannelService _channelService;

        public ChannelController(IChannelService channelService)
        {
            _channelService = channelService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _channelService.Get(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(ChannelDto dto)
        {
            await _channelService.Add(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _channelService.Remove(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ChannelDto dto)
        {
            await _channelService.Update(dto);
            return Ok();
        }

        [HttpGet("query")]
        public async Task<IActionResult> Query(int take = 20, int skip = 0)
        {
            return Ok();
        }
    }
}