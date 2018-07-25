using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Playlist;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class PlaylistController : GoogleController
    {
        private readonly IPlaylistService _playlistService;
        private readonly IVideoPlaylistService _videoPlaylistService;

        public PlaylistController(
            IPlaylistService playlistService, 
            IVideoPlaylistService videoPlaylistService)
        {
            _playlistService = playlistService;
            _videoPlaylistService = videoPlaylistService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _playlistService.Get(id);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(PlaylistDto dto)
        {
            await _playlistService.Add(dto);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _playlistService.Remove(id);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(PlaylistDto dto)
        {
            await _playlistService.Update(dto);
            return Ok();
        }

        [HttpGet("query")]
        public async Task<IActionResult> Query(string channelId, int take = 20, int skip = 0)
        {
            return Ok();
        }

        [HttpPut("reOrder")]
        public async Task<IActionResult> ReOrderVideo(PlaylistReOrderVideoDto playlistReOrderVideoDto)
        {
            await _videoPlaylistService.ReOrder(playlistReOrderVideoDto);
            return Ok();
        }
    }
}