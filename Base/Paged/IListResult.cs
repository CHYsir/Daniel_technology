﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base.Paged
{
    //返回结果列表接口IListResult

    public interface IListResult<T>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        /// IListResult<T>接受一个参数，并将其指定为IReadOnlyList返回。
        IReadOnlyList<T> Item { get; set; }

    }
}
