using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class Consumption : BasicAggregateRoot<int> //消费信息
    {
        public DateTime ConsumptionTime { get; set; } //消费时间
        public decimal ConsumptionMoney { get; set; } //消费金额
        public int goodsId { get; set; } //商品Id 连接商品表

    }
}
