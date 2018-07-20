using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Google.Model.Entities;

namespace Google.Service.Dtos
{
    public class TagDto: BaseDto
    {
        public string Name { get; set; }

        public Guid AccountId { get; set; }

        public virtual AccountDto CreatedBy { get; set; }
    }
}