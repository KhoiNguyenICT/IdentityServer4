using Google.Common.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Account : IdentityUser<Guid>, IEntity
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}".Trim();

        public Guid? ProfileImageId { get; set; }

        public Guid? CoverImageId { get; set; }

        [ForeignKey("ProfileImageId")]
        public virtual Asset ProfileImage { get; set; }

        [ForeignKey("CoverImageId")]
        public virtual Asset CoverImage { get; set; }

        [Required]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}