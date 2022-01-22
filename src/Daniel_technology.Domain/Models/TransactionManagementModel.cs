using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class TransactionManagementModel : BasicAggregateRoot<int>
    {
        //交易管理
        public string TradingHours { get; set; }//交易时间
        public string TradingSite { get; set; }//交易地点
        public string NameTransaction { get; set; }//交易货品名称
        public string DealPrice { get; set; }//交易单价
        public string Numberdeals { get; set; }//交易数量
        public string Price { get; set; }//交易总价
        public string PhoneNumber { get; set; }//联系电话
    }
}
