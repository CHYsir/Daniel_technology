using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class AccountDetails : BasicAggregateRoot<int> //账户明细表
    {
        public DateTime ApplyForTime { get; set; } //申请日期
        public DateTime AccountTime { get; set; } //到账时间
        public string Applicant { get; set; } //申请人
        public decimal WithdrawMoney { get; set; } //提现账户
        public decimal ApplyForMoney { get; set; } //申请金额
        public decimal TransferCommission { get; set; } //转账手续费
        public decimal ArrivalAmount { get; set; } //实际到账金额
        public int State { get; set; } //状态  0:已审核 1:未审核

    }
}
