using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class VideoPlaylist : BaseEntity
    {
        [Required]
        public Guid VideoId { get; set; }

        [Required]
        public Guid PlaylistId { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }

        public int Order { get; set; }
    }
}