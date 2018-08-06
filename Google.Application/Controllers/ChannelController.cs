using System;
using System.Threading.Tasks;
using Google.Common.Constants;
using Google.Service.Dtos.Channel;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Google.Application.Controllers
{
    public class ChannelController : GoogleController
    {
        private readonly IChannelService _channelService;
        private readonly IConfiguration _configuration;

        public ChannelController(IChannelService channelService, IConfiguration configuration)
        {
            _channelService = channelService;
            _configuration = configuration;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _channelService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]ChannelDto dto)
        {
            dto.AvatarId = dto.AvatarId == Guid.Empty ? new Guid(_configuration[ConfigurationKeys.DefaultAssetId]) : dto.AvatarId;
            dto.ThumbnailId = dto.ThumbnailId == Guid.Empty ? new Guid(_configuration[ConfigurationKeys.DefaultAssetId]) : dto.ThumbnailId;
            await _channelService.AddAsync(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _channelService.RemoveAsync(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ChannelDto dto)
        {
            await _channelService.UpdateAsync(dto);
            return Ok();
        }

        [HttpGet("query")]
        public async Task<IActionResult> Query(int take = 20, int skip = 0)
        {
            var result = await _channelService.Query(skip, take);
            return Ok(result);
        }
    }
}