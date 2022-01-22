using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base.Paged
{
    //新建ListResult实现类，继承IListResult，在构造函数中为其赋值
    //最后新建我们的分页响应实体接口：IPagedList和分页响应实体实现类：PagedList，它同时也要接受一个泛型参数 T

    public class ListResult<T>:IListResult<T>
    {
        IReadOnlyList<T> item;

        public IReadOnlyList<T> Item
        {
            get => item ?? (item = new List<T>());
            set => item = value;
        }

        public ListResult()
        {
        }

        public ListResult(IReadOnlyList<T> item)
        {
            Item = item;
        }

    }
}
