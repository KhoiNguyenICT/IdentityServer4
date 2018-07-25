using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Video;
using Google.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Google.Service.Implementations
{
    public class VideoPlaylistService : BaseService<VideoPlaylist, VideoPlaylistDto>, IVideoPlaylistService
    {
        public VideoPlaylistService(AppDbContext context) : base(context)
        {
        }

        public async Task ReOrder(PlaylistReOrderVideoDto playlistReorderVideo)
        {
            var video = await _context.VideoPlaylists.FirstOrDefaultAsync(x => x.VideoId == playlistReorderVideo.VideoId);
            video.Order = playlistReorderVideo.NewOrder;
            await _context.SaveChangesAsync();
        }
    }
}