using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Daniel_technology.Models
{
    public class MemberInformationModel : BasicAggregateRoot<int>//会员详情
    {
        
        public string Head_portrait  { get; set; }//会员头像  图片
        
        public int Member_Id { get; set; }//会员ID 
        
        public string Nickname { get; set; }//会员昵称
        
        public string Phone { get; set; }//会员手机
        
        public int Sex { get; set; }//会员性别  0:男 1:女  2:保密

        public int AddressId { get; set; } //地域归属 /地址 下拉框  Id
        
        public DateTime RegisterTime { get; set; }//注册时间 默认时间
        
        public int RegisterSourceId { get; set; }//注册来源 /扫码注册/刷脸注册  下拉框 Id
        
        public int Number_Purchased { get; set; }//购买次数  默认为0   连接 消费信息表 的信息数量（条）
        
        public decimal Total_Amount { get; set; }//累计消费金额 默认0.00  连接 消费信息表 的消费金额总和

    }
}
