using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    /// <summary>
    /// 交易信息
    /// </summary>
    public class TradingInformation : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 主键id
        /// </summary>
     //   public Guid Id { get; set; } = new Guid();
        /// <summary>
        /// 商品名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public string CategoryPrice { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int States { get; set; }
        /// <summary>
        /// 交易人id
        /// </summary>
        public Guid CreateId { get; set; }
        /// <summary>
        /// 交易人昵称
        /// </summary>
        public string CreateName { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        public DateTime CreateTime { get; set; } = new DateTime();
    }
}
