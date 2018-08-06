using System;
using System.Threading.Tasks;
using Google.Service.Dtos.Channel;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class ChannelController : GoogleController
    {
        private readonly IChannelService _channelService;
        private readonly IAssetService _assetService;

        public ChannelController(IChannelService channelService, IAssetService assetService)
        {
            _channelService = channelService;
            _assetService = assetService;
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
            var defaultAsset = await _assetService.GetDefaultAsset();
            dto.AvatarId = dto.AvatarId == Guid.Empty ? defaultAsset.Id: dto.AvatarId;
            dto.ThumbnailId = dto.ThumbnailId == Guid.Empty ? defaultAsset.Id : dto.ThumbnailId;
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
            return Ok();
        }
    }
}