using Google.Common.Cores;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Video;
using Google.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Common.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Google.Service.Implementations
{
    public class VideoService : BaseService<Video, VideoDto>, IVideoService
    {
        public VideoService(AppDbContext context) : base(context)
        {
        }

        public Task<QueryResult<VideoDto>> QueryAsync(Guid channelId, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}