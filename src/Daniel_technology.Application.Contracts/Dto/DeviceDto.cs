using System;
using System.Collections.Generic;
using System.Text;

namespace Daniel_technology.Dto
{
    //设备
    public class DeviceDto
    {
        public int Id { get; set; }
        public string EquipName { get; set; }//设备名称
        public string brand { get; set; }//设备品牌
        public string Size { get; set; }//设备尺寸
        public string Manufacturer { get; set; }//生产厂家
        public DateTime Productiondate { get; set; }//生产日期
        public string Number { get; set; }//生产数量

        public string perfomance { get; set; }//设备性能
        public string MarketGrade { get; set; }//市场等级
        public string Design { get; set; }//设计规格
        public string rawmaterial { get; set; }//原材料

        public string Function { get; set; }//设备功能
        public string Termsofpayment { get; set; }//付款方式
        public string Capacity { get; set; }//设备容量
    }
}
