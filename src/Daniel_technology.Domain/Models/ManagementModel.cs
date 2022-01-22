using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class ManagementModel : BasicAggregateRoot<int>
    {
        //设备管理
        //设备管理名称
        public string Serial { get; set; }//设备编号
        public string MangNmae { get; set; }//设备管理名称
        public int  Static { get; set; }//设备售卖状态


        public string Production { get; set; }//生产编号
        public string  Versin{ get; set; }//产品型号

    }
}
