using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class RoleMenuModel : BasicAggregateRoot<int>
    {
        //角色菜单关联表
        
        
        /// <summary>


     /// 主键Id
     /// </summary>
        // public int Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public int PermissionsId { get; set; }
    }
}
