using System;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Account;

namespace Google.Service.Dtos.Category
{
    public class CategoryDto : BaseDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }
        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }
    }
}