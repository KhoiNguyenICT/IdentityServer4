using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Google.Model.Entities;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Asset;
using Google.Service.Dtos.Channel;

namespace Google.Service.Dtos.Category
{
    public class CategoryDto : BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public Guid ThumbnailId { get; set; }

        public virtual AssetDto Thumbnail { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }

        public virtual ICollection<ChannelDto> Channels { get; set; }
    }
}