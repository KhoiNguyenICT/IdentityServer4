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

        public async Task<QueryResult<VideoDto>> QueryAsync(Guid channelId, int page, int pageSize)
        {
            var query = _context.Videos.Where(x => x.ChannelId == channelId);
            var totalRow = query.Count();
            var result = await query.OrderByDescending(x => x.CreatedDate).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var data = result.To<List<VideoDto>>();
            var paginationSet = new QueryResult<VideoDto>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
    }
}