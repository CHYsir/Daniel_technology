using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    //仓库
    public class Warehouse:BasicAggregateRoot<int>
    {
        //商品名称
        public string GoodsName { get; set; }
        //商品状态
        public int State { get; set; }
        //规格
        public string Specifications { get; set; }
        //实际数量
        public int TrueNumber { get; set; }
        //账面数量
        public int BookNumber { get; set; }
        //差异数量
        public int DifferencesNumber { get; set; }
        //价格
        public decimal Price { get; set; }
        //差异价格
        public decimal DifferencesPrice { get; set; }
        //差异原因
        public string DifferencesWhy { get; set; }
        //存放位置
        public string Location { get; set; }
        //操作人
        public string Operation { get; set; }
    }
}
