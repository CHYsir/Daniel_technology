using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    //商户统计表（代理商/商户/会员）
    public class UserStatistics : BasicAggregateRoot<int>
    {
      //  public int Id { get; set; }             
        public int SId { get; set; }    //商户Id
        public string  SName { get; set; }   //商户姓名
        public string  SSex { get; set; }       //商户性别
        public string SAge { get; set; }       //商户年龄
       
    }
}
