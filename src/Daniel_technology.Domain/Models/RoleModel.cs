using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class RoleModel : BasicAggregateRoot<int>
    {
        //角色表
        /// <summary>
        /// 主键Id
        /// </summary>
      //  public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 角色描述
        /// </summary>
        public DateTime RoleDescribe { get; set; }
        /// <summary>
        /// 角色级别
        /// </summary>
        public int RoleLevel { get; set; }
    }
}
