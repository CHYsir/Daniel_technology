using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class MemberModel : BasicAggregateRoot<int>
    {
        //会员管理
        public string MemberName { get; set; }//会员名称
        public string MembershipNumber { get; set; }//会员编号
        public string MobilePhoneNumber { get; set; }//会员手机号
        public string OpeningTime { get; set; }//开通时间
        public string GNmber { get; set; }//购买数量
        
    }
}
