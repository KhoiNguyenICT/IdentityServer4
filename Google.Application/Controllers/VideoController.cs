using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Tag;
using Google.Service.Dtos.Video;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class VideoController : GoogleController
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _videoService.Get(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(VideoDto dto)
        {
            await _videoService.Add(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _videoService.Remove(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(VideoDto dto)
        {
            await _videoService.Update(dto);
            return Ok();
        }

        [HttpGet("channel/{channelId}/videos")]
        public async Task<IActionResult> Query(Guid channelId, int take = 20, int skip = 0)
        {
            var result = await _videoService.Query(channelId, skip, take);
            return Ok(result);
        }
    }
}