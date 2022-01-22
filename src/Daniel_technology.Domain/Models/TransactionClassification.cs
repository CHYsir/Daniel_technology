using System;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    /// <summary>
    /// 交易分类表
    /// </summary>
    public class TransactionClassification : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 主键id
        /// </summary>
    //    public Guid Id { get; set; } = new Guid();
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int States { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public Guid CreateId { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = new DateTime();
    }
}
