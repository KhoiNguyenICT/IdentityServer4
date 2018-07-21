using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos;
using Google.Service.Dtos.Video;
using Google.Service.Interfaces;

namespace Google.Service.Implementations
{
    public class VideoService: BaseService<Video, VideoDto>, IVideoService
    {
        public VideoService(AppDbContext context) : base(context)
        {
        }
    }
}