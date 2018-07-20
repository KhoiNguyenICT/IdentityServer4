using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class PlaylistTag : BaseEntity
    {
        [Required]
        public Guid PlaylistId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        [ForeignKey("PlaylistId")]
        public virtual Playlist Playlist { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}