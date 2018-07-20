using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Channel : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public string Email { get; set; }
        public string HyperLink { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account CreatedBy { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}