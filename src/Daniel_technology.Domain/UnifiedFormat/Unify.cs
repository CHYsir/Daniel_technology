using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_technology.UnifiedFormat
{
    /// <summary>
    /// 返回格式表
    /// </summary>
    public class Unify
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public int ReturnCode { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public object Data { get; set; }


        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        //返回状态
        public string ToTak { get; set; }
    }
}
