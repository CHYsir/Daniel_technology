using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
   public class Equipuse : BasicAggregateRoot<int>
    {
        public string Function { get; set; }//设备功能
        public string Termsofpayment { get; set; }//付款方式
        public string Capacity { get; set; }//设备容量
    }
}
