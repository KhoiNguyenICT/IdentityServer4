using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class VideoTag : BaseEntity
    {
        [Required]
        public Guid VideoId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}