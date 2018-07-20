using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class CategoryTag: BaseEntity
    {
        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }
    }
}