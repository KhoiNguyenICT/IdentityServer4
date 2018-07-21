using System;
using System.Threading.Tasks;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Playlist;
using Google.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Google.Application.Controllers
{
    public class PlaylistController : GoogleController
    {
        private readonly IPlaylistService _playlistService;

        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
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
    }
}