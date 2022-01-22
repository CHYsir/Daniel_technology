using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class PayType : BasicAggregateRoot<int> //支付类型
    {
        public string Pay { get; set; } //类型名
    }
}
