using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class ClosingDetail : BasicAggregateRoot<int> //结算明细
    {
        public DateTime ClosingTime { get; set; } //结算日期   
        public decimal VXSalesAmount  { get; set; } //微信销售金额
        public decimal VXTransactionFee { get; set; } //微信交易费
        public decimal ZFBSalesAmount { get; set; } // 支付宝销售金额
        public decimal ZFBTransactionFee { get; set; } //支付宝交易费
        public decimal PlatformServiceCharge { get; set; } //平台服务费
        public decimal ArithmeticServiceCharge { get; set; } //算法服务费
        public decimal OrderFormMoney { get; set; } //订单金额
        public decimal CashWithdrawalAmount { get; set; } //提现金额


    }
}
