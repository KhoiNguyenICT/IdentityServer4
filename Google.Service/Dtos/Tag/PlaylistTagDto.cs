using System;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Playlist;

namespace Google.Service.Dtos.Tag
{
    public class PlaylistTagDto: BaseDto
    {
        [Required]
        public Guid PlaylistId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        public virtual PlaylistDto Playlist { get; set; }

        public virtual TagDto Tag { get; set; }
    }
}