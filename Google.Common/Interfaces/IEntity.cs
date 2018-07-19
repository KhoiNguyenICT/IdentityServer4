using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Common.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }

        DateTime CreatedDate { get; set; }

        DateTime UpdatedDate { get; set; }
    }
}
