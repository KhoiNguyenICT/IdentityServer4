using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Model.Entities;

namespace Google.Service.Dtos
{
    public class PlaylistTagDto: BaseDto
    {
        [Required]
        public Guid PlaylistId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        public virtual PlaylistDto Playlist { get; set; }

        public virtual Tag Tag { get; set; }
    }
}