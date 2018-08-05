using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; }
    }
}