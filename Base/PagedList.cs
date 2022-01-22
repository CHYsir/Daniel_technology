using Daniel_technology.Base.Paged;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base
{
    /// <summary>
    /// 分页响应实体   它同时也要接受一个泛型参数 T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedList<T>: ListResult<T>, IPagedList<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Total { get; set; }

        public PagedList()
        {
        }

        public PagedList(int total, IReadOnlyList<T> result) : base(result)
        {
            Total = total;
        }

    }
}
