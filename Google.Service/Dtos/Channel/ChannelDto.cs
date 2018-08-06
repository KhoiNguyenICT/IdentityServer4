using Google.Service.Dtos.Account;
using Google.Service.Dtos.Asset;
using Google.Service.Dtos.Category;
using Google.Service.Dtos.Playlist;
using Google.Service.Dtos.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos.Channel
{
    public class ChannelDto : BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Guid ThumbnailId { get; set; }

        public Guid AvatarId { get; set; }

        public string Description { get; set; }
        public string EmailContact { get; set; }
        public string[] HyperLinks { get; set; }

        [Required]
        public Guid CreateById { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        public virtual AssetDto Thumbnail { get; set; }

        public virtual AssetDto Avatar { get; set; }

        public virtual AccountDto CreatedBy { get; set; }

        public virtual AccountDto Owner { get; set; }

        public virtual CategoryDto Category { get; set; }

        public virtual ICollection<PlaylistDto> Playlists { get; set; }

        public virtual ICollection<VideoDto> Videos { get; set; }
    }
}