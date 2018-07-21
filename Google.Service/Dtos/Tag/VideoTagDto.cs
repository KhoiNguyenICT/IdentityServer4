using System;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Video;

namespace Google.Service.Dtos.Tag
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