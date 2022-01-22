using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class AddressModel : BasicAggregateRoot<int>  //地址表
    {
        public int FatherId { get; set; } //父Id
        public string Address { get; set; } //地址

    }
}
