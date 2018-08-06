using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Common.Cores
{
    public class QueryResult<T>
    {
        public long Count { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}