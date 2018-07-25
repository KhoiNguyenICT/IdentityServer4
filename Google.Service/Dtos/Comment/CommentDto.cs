using System;
using System.ComponentModel.DataAnnotations;
using Google.Service.Dtos.Account;
using Google.Service.Dtos.Channel;
using Google.Service.Dtos.Video;

namespace Google.Service.Dtos.Comment
{
    public class CommentDto: BaseDto
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