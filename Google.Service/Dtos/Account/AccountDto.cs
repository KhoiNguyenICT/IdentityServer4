using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Model.Entities;
using Google.Service.Dtos.Asset;
using Google.Service.Interfaces;

namespace Google.Service.Dtos.Account
{
    public class AccountDto : IDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}".Trim();

        [Required]
        public Guid ProfileImageId { get; set; }

        [Required]
        public Guid CoverImageId { get; set; }

        public virtual AssetDto ProfileImage { get; set; }

        public virtual AssetDto CoverImage { get; set; }

        [Required]
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}