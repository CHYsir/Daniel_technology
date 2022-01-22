using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{

    //交易统计表（金额/订单/笔数）
    public class Statistics : BasicAggregateRoot<int>
    {
       // public int      Id { get; set; }                                      //Id
        public string Money { get; set; }                               //SaaS单价
        public string     Orderform { get; set; }                     //SaaS订单号
        public string     Count { get; set; }                            //SaaS购买笔数
        public int SId { get; set; }                                         //SaaS购买人

    }
}
