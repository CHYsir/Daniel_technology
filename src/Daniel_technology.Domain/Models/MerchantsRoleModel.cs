using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    /// <summary>
    /// 商户角色表
    /// </summary>
    public class MerchantsRoleModel : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string MerchantsRoleName { get; set; }
    }
}
