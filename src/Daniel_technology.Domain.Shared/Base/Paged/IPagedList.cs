using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base.Paged
{
    //最后新建我们的分页响应实体接口：IPagedList和分页响应实体实现类：PagedList，它同时也要接受一个泛型参数 T

    public interface IPagedList<T>:IListResult<T>,IHasTotalCount
    {
    }
}
