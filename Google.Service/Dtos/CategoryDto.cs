using System;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
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