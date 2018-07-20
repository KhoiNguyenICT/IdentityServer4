using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Model.Entities;

namespace Google.Service.Dtos
{
    public class ChannelDto: BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Email { get; set; }
        public string HyperLink { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }

        public virtual ICollection<PlaylistDto> Playlists { get; set; }
    }
}