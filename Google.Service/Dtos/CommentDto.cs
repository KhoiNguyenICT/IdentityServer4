using System;
using System.ComponentModel.DataAnnotations;

namespace Google.Service.Dtos
{
    public class CommentDto
    {
        [Required]
        public Guid AccountId { get; set; }
        public Guid? ChannelId { get; set; }
        public Guid? VideoId { get; set; }
        public string Content { get; set; }

        public virtual VideoDto Video { get; set; }

        public virtual AccountDto CommentBy { get; set; }

        public virtual ChannelDto Channel { get; set; }
    }
}