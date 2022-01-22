using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
  public  class Equipspecification : BasicAggregateRoot<int>
    {
        public string perfomance { get; set; }//设备性能
        public string MarketGrade { get; set; }//市场等级
        public string Design { get; set; }//设计规格
        public string rawmaterial { get; set; }//原材料
    }
}
