using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    /// <summary>
    /// 商户信息表
    /// </summary>
    public class MerchantsInformationModel : BasicAggregateRoot<int>
    {

        /// <summary>
        /// 商户ID
        /// </summary>
      //  public string MerchantsID { get; set; }
              
        /// <summary>
        /// 商户名称
        /// </summary>
        public string MerchantsName { get; set; }

        /// <summary>
        /// 商户账号
        /// </summary>
        public string MerchantsAccount { get; set; }

        /// <summary>
        /// 商户地区  （外键）
        /// </summary>
        public int MerchantsAddress { get; set; }

        /// <summary>
        /// 商户Login 
        /// </summary>
        public string MerchantsLogin { get; set; }
        

        /// <summary>
        /// 商户状态
        /// </summary>
        public int MerchantsState { get; set; }


        /// <summary>
        /// 商户创建时间
        /// </summary>
        public DateTime MerchantsCreateTime { get; set; }


        /// <summary>
        /// 商户角色 (外键)
        /// </summary>
        public int MerchantsRole { get; set; }

        /// <summary>
        /// 商户最后登录时间
        /// </summary>
        public DateTime MerchantsLastLoginTime { get; set; }


    }
}
