using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    //商品管理
    public class Merchant_Goods : BasicAggregateRoot<int>
    {
  
        public int Goods_Ids { get; set; }//普通id
        public int Goods_Type { get; set; }//类型
        public int Goods_Clicks { get; set; }//点击量
        public string Goods_Bar_Code { get; set; }//条形码
        public string Goods_Name { get; set; }//商品名称
        public string Goods_Photo { get; set; }//商品图片
        public string Goods_Describes { get; set; }//商品介绍
        public int Goods_Number { get; set; }//商品数量
        public int Goods_Inventory { get; set; }//商品库存
        public bool Goods_State { get; set; }//商品状态
        public decimal Goods_Price { get; set; }//商品单价
        public decimal Goods_PriceSum { get; set; }//商品总价
        public decimal Goods_Weight { get; set; }//商品重量
        public string Goods_Color { get; set; }//商品颜色   黑色、红色、白色等
        public string Goods_Flats { get; set; }//商品单位   个、袋、箱、条等 

        public DateTime Goods_CreateTime { get; set; }//商品添加时间
        public DateTime Goods_UpdateTime { get; set; }//商品修改时间
        public DateTime Goods_DeleteTime { get; set; }//商品删除时间
        public string Goods_CreateName { get; set; }//商品添加人
        public string Goods_UpateName { get; set; }//商品修改人
        public string Goods_DeleteName { get; set; }//商品删除人
    }
}
