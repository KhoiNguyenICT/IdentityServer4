using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos;
using Google.Service.Dtos.Playlist;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class PlaylistService: BaseService<Playlist, PlaylistDto>, IPlaylistService
    {
        public PlaylistService(AppDbContext context) : base(context)
        {
        }
    }
}