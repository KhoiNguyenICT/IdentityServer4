using System;
using Google.Service.Dtos.Category;

namespace Google.Service.Dtos.Tag
{
    public class CategoryTagDto : BaseDto
    {
        public Guid CategoryId { get; set; }
        public Guid TagId { get; set; }

        public virtual CategoryDto Category { get; set; }

        public virtual TagDto Tag { get; set; }
    }
}