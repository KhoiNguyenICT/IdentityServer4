using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Comment : BaseEntity
    {
        [Required]
        public Guid CreateById { get; set; }
        public Guid? ChannelId { get; set; }
        public Guid? VideoId { get; set; }
        public string Content { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account CommentBy { get; set; }

        [ForeignKey("ChannelId")]
        public virtual Channel Channel { get; set; }
    }
}