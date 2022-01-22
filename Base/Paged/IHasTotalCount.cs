using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base.Paged
{
    //新建文件夹Paged，添加总数接口IHasTotalCount

    public interface IHasTotalCount
    {
        /// <summary>
        /// 总数
        /// </summary>
        int Total { get; set; }

    }
}
