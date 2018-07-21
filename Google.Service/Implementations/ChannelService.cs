using Google.Model;
using Google.Model.Entities;
using Google.Service.Dtos;
using Google.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Google.Service.Dtos.Channel;

namespace Google.Service.Implementations
{
    public class ChannelService : BaseService<Channel, ChannelDto>, IChannelService
    {
        public ChannelService(AppDbContext context) : base(context)
        {
        }
    }
}