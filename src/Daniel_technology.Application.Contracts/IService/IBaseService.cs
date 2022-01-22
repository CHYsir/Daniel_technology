using Daniel_technology.Base;
using Daniel_technology.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_technology.IService
{
    public interface IBaseService<T> :Volo.Abp.Application.Services.IApplicationService where T : class,new()
    {
        //添加
        Task<ServiceResult<string>> AddAsync(T model);

        //显示
        Task<ServiceResult<T>> GetList();

        //修改
        Task<ServiceResult<T>> UpdateAsync(T model);

        //删除
        Task<ServiceResult> DeleteAsync(int id);

        //查询
        Task<ServiceResult<T>> SelectAsync(int id);
    }
}
