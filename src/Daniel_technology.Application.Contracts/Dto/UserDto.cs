using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Dto
{
    public class UserDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
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
