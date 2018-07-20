using System;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
{
    public class VideoTagDto: BaseDto
    {
        [Required]
        public Guid VideoId { get; set; }

        [Required]
        public Guid TagId { get; set; }

        public virtual VideoDto Video { get; set; }

        public virtual TagDto Tag { get; set; }
    }
}