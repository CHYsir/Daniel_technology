using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class TransactionType : BasicAggregateRoot<int> //交易类型
    {
        public string Transaction { get; set; }
    }
}
