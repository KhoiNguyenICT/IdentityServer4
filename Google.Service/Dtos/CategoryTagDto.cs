using System;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Model.Entities;

namespace Google.Service.Dtos
{
    public class CategoryTagDto : BaseDto
    {
        public Guid CategoryId { get; set; }
        public Guid TagId { get; set; }

        public virtual CategoryDto Category { get; set; }

        public virtual TagDto Tag { get; set; }
    }
}