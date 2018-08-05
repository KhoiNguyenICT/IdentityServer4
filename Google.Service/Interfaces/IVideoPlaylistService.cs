using System.Threading.Tasks;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Video;

namespace Google.Service.Interfaces
{
    public interface IVideoPlaylistService: IService<VideoPlaylistDto>
    {
        Task ReOrderAsync(PlaylistReOrderVideoDto playlistReorderVideo);
    }
}