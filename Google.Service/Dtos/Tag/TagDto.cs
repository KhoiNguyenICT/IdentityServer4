using System;
using Google.Service.Dtos.Account;

namespace Google.Service.Dtos.Tag
{
    public class TagDto: BaseDto
    {
        public string Name { get; set; }

        public Guid CreateById { get; set; }

        public virtual AccountDto CreatedBy { get; set; }
    }
}