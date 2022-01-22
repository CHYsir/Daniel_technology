using Daniel_technology.Base.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Base
{
    //这里的T就是我们的返回结果，然后继承我们的ServiceResult，指定T为class。并重新编写一个IsSuccess(...)方法

    //此时针对无需返回参数和需要返回参数的api都可以满足要求了。但是还有一种就没办法了，那就是带分页的数据，我们都应该知道想要分页，数据总数肯定是必不可少的。
    //所以此时还需要扩展一个分页的响应实体，当我们使用的时候，直接将分页响应实体作为上面写的ServiceResult<T> 中的T参数，即可满足需求。
    //新建文件夹Paged，添加总数接口IHasTotalCount、返回结果列表接口IListResult

    /// <summary>
    /// 服务层响应实体（泛型）
    /// </summary>
    public class ServiceResult<T>:ServiceResult where T : class
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// 响应成功
        /// </summary>
        /// <param name="result"></param>
        /// <param name="message"></param>
        public void IsSuccess(T result = null, string message = "")
        {
            Message = message;
            Code = ServiceResultCode.Succeed;
            Result = result;
        }

    }
}
