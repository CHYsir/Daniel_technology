using Daniel_technology.Base;
using Daniel_technology.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_technology.IService
{
    public interface ILoginService: Volo.Abp.Application.Services.IApplicationService
    {
        //登录
        Task<ServiceResult<UserDto>> Login(UserDto model);

        //添加
        Task<ServiceResult<string>> AddUser(UserDto model);

        //删除
        Task<ServiceResult> DeleteUser(int id);

        //修改
        Task<ServiceResult<string>> UpdateUser(int id, UserDto model);

        //查询
        Task<ServiceResult<UserDto>> SelectList(int id);

        //显示
        Task<List<UserDto>> GetList();


    }
}
