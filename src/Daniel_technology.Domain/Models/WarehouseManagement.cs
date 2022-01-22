using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    //仓库管理
    public class WarehouseManagement:BasicAggregateRoot<int>
    {
        //商品名称
        public string GoodsName { get; set; }
        //订单编号
        public Guid OrderNo { get; set; }
        //入库时间
        public DateTime StorageTime { get; set; }
        //出库时间
        public DateTime DeliveryTime { get; set; }
        //入库数量
        public int StorageNumber { get; set; }
        //出库数量
        public int DeliveryNumber { get; set; }
        //描述
        public string Remark { get; set; }
        //状态
        public int State { get; set; }
        //操作人
        public string Operation { get; set; }
    }
}
