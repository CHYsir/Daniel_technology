using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class RegisterSourceModel : BasicAggregateRoot<int>  //注册来源表
    {
        public string RegisterSource { get; set; } //来源
    }
}
