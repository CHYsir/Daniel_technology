using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class UserModel : BasicAggregateRoot<int>
    {
        //用户表
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 登录状态
        /// </summary>
        public int LgoinStatus { get; set; }
        /// <summary>
        /// 详细信息
        /// </summary>
        public string Detailed { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string UserPhone { get; set; }
        /// <summary>
        /// 注册账号
        /// </summary>
        public string UserAccount { get; set; }
    }
}
