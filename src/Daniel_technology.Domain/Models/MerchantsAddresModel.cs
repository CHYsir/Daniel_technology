using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    /// <summary>
    /// 商户地址
    /// </summary>
    public class MerchantsAddresModel : BasicAggregateRoot<int>
    {
        /// <summary>
        /// 地址父ID
        /// </summary>
        public int MerchantsAddresTid { get; set; }

        public string MerchantsAddresName { get; set; }
    }
}
