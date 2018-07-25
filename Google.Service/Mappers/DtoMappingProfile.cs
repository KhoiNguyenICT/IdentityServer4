using AutoMapper;
using Google.Model.Entities;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Category;
using Google.Service.Dtos.Channel;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Configuration;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Tag;
using Google.Service.Dtos.Video;

namespace Google.Service.Mappers
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {

        }

        public void MapBase()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryTag, CategoryTag>();
            CreateMap<Channel, ChannelDto>();
            CreateMap<Comment, CommentDto>();
            CreateMap<ConfigurationValue, ConfigurationValueDto>();
            CreateMap<Log, LoginDto>();
            CreateMap<Playlist, PlaylistDto>();
            CreateMap<PlaylistTag, PlaylistTag>();
            CreateMap<Tag, TagDto>();
            CreateMap<Video, VideoDto>();
            CreateMap<VideoPlaylist, VideoPlaylistDto>();
            CreateMap<VideoTag, VideoTagDto>();
        }
    }
}