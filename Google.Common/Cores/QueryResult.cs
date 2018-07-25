using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Common.Cores
{
    public class QueryResult<T> : QueryResultBase where T : class
    {
        public QueryResult()
        {
            Results = new List<T>();
        }

        public IList<T> Results { get; set; }
    }
    public abstract class QueryResultBase
    {
        public int CurrentPage { get; set; }

        public int PageCount
        {
            get
            {
                var pageCount = (double) RowCount / PageSize;
                return (int) Math.Ceiling(pageCount);
            }
            set { PageCount = value; }
        }

        public int PageSize { get; set; }
        public int RowCount { get; set; }

        public int FirstRowPage
        {
            get { return (CurrentPage - 1) * PageSize + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, RowCount); }
        }
    }
}