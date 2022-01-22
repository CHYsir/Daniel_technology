using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
   public class EquipInfos : BasicAggregateRoot<int>
    {
        public string EquipName { get; set; }//设备名称
        public string brand { get; set; }//设备品牌
        public string Size { get; set; }//设备尺寸
        public string Manufacturer { get; set; }//生产厂家
        public DateTime Productiondate { get; set; }//生产日期
        public string Number { get; set; }//生产数量
    }
}
