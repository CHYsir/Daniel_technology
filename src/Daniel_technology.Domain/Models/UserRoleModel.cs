using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class UserRoleModel : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 用户角色关联表
        /// </summary>
        /// <summary>
        /// 主键Id
        /// </summary>
        //    public int Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }


    }

}
