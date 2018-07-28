using AutoMapper;
using Google.Common.Constants;
using Google.Common.Extensions;
using Google.Model.Entities;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Category;
using Google.Service.Dtos.Channel;
using Google.Service.Dtos.Comment;
using Google.Service.Dtos.Configuration;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Tag;
using Google.Service.Dtos.Video;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Google.Service.Mappers
{
    public class DtoMappingProfile : Profile
    {
        private IConfiguration _configuration;

        public DtoMappingProfile(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DtoMappingProfile()
        {
            MapBase();
            AssetMap();
        }

        private void MapBase()
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

        private void AssetMap()
        {
            CreateMap<IFormFile, Asset>()
                .ForMember(d => d.AssetsPrimaryName, s => s.MapFrom(x => x.FileName))
                .ForMember(d => d.ContentType, s => s.MapFrom(x => x.ContentType))
                .ForMember(d => d.AssetName, s => s.MapFrom(x => StringExtensions.GenerateAssetName(x.FileName)))
                .ForMember(d => d.FileSize, s => s.MapFrom(x => x.Length))
                .ForMember(d => d.AddressFile, s => s.MapFrom(x => StringExtensions.GenerateAddressAssetName(x.FileName)));
        }
    }
}