using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Common.Interfaces
{
    public interface IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Guid Id { get; set; }

        DateTime CreatedDate { get; set; }

        DateTime UpdatedDate { get; set; }
    }
}