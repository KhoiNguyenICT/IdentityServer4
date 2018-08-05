using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CreateById { get; set; }

        [ForeignKey("CreateById")]
        public virtual Account CreatedBy { get; set; }
    }
}