using System;
using System.ComponentModel.DataAnnotations;
using Google.Common.Enums;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Asset;

namespace Google.Service.Dtos.Playlist
{
    public class PlaylistDto: BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public Guid ThumbnailId { get; set; }
        public PlayListStatusType PlayListStatusType { get; set; }

        public virtual AssetDto Thumbnail { get; set; }

        [Required]
        public Guid CreateById { get; set; }

        public AccountDto CreatedBy { get; set; }
    }
}