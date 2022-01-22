using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class MenuModel : BasicAggregateRoot<int>//菜单表
    {
        /// <summary>
        /// 主键Id
        /// </summary>
     //   public int Id { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuNaeme { get; set; }
        /// <summary>
        /// 菜单子集
        /// </summary>
        public string MenuChildren { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public int MenuPID { get; set; }
        /// <summary>
        /// 菜单地址
        /// </summary>
        public string MenuUrl { get; set; }
    }
}
