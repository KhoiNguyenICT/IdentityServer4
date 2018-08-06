using Google.Common.Cores;
using Google.Common.Extensions;
using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos.Channel;
using Google.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Service.Implementations
{
    public class ChannelService : BaseService<Channel, ChannelDto>, IChannelService
    {
        public ChannelService(AppDbContext context) : base(context)
        {
        }

        public async Task<QueryResult<ChannelDto>> Query(int skip, int take)
        {
            var channels = _context.Channels.Include(x => x.Category);
            var result = await channels.Skip(skip).Take(take).ToListAsync();
            return new QueryResult<ChannelDto>()
            {
                Count = channels.Count(),
                Items = result.To<IEnumerable<ChannelDto>>()
            };
        }
    }
}