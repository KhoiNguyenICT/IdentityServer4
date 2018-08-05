using System;
using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Video;

namespace Google.Service.Interfaces
{
    public interface IVideoService: IService<VideoDto>
    {
        Task<QueryResult<VideoDto>> QueryAsync(Guid channelId, int page, int pageSize);
    }
}