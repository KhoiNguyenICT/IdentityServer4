using System;
using Google.Service.Interfaces;

namespace Google.Service.Dtos
{
    public class BaseDto: IDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}