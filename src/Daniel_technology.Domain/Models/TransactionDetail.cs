using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class TransactionDetail : BasicAggregateRoot<int>//交易明细
    {
        public decimal TransactionTime { get; set; } //交易日期
        public int TransactionTypeId { get; set; } //交易类型
        public string SerialNumber { get; set; } //流水号
        public string Phone { get; set; } //手机号
        public int PayTypeId { get; set; } //支付类型
        public string EquipmentNumber { get; set; } //设备编号
        public decimal TransactionMoney { get; set; } //交易金额

    }
}
