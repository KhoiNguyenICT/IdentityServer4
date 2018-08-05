using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Google.Model.Entities;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Asset;
using Google.Service.Dtos.Channel;

namespace Google.Service.Dtos.Category
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
        public CategoryDto Parent { get; set; }

        public ICollection<CategoryDto> Children { get; set; }
    }
}