using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class ConfigurationModel : BasicAggregateRoot<int>//运营配置
    {
        /// <summary>
        /// 基础配置
        /// </summary>
        public string Equipment { get; set; }//设备编号
        public string StrName { get; set; }//设备名称
        public string DeviceAddress { get; set; }//设备地址哪里发货的
        public string DetailsAddress { get; set; }//详情地址
        public string Customer { get; set; }//客服电话
        public string SetTheNote { get; set; }//设置备注
        public string AudioEquipment { get; set; }//设备音量
    }
}
