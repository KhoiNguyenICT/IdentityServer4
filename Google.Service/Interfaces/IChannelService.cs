using System.Threading.Tasks;
using Google.Common.Cores;
using Google.Service.Dtos.Channel;

namespace Google.Service.Interfaces
{
    public interface IChannelService: IService<ChannelDto>
    {
        Task<QueryResult<ChannelDto>> Query(int skip, int take);
    }
}