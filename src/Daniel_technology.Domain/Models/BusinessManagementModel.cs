using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class BusinessManagementModel : BasicAggregateRoot<int>//售卖机商户管理
    {
        public string BuyStore { get; set; }//购买店铺
        public string PurchasePrice { get; set; }//购买价格
        public string PurchaseQuantity { get; set; }//购买数量
        public string BusinessAddress { get; set; }//商户地址
        public string MerchantsCall { get; set; }//商户电话
        
    }
}
