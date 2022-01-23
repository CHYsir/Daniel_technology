using Daniel_technology.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Daniel_technology.IService
{
    //在不知道返回类型的情况下可以用元组Tuple<>,括号里最多放8个，每一个里又可以嵌套Tuple<int,Tuple<int ,int>,string>
    //Tuple<int,string> Add(UserModel model);
    //接口中尽量用异步 Async,现在的所有编程中用的都是同步  从上往下叫同步，上一步出错下一步就不会执行
    //异步，不用等上一步执行完就可以执行下一步操作
    //Task: Async,Await
    //重载：方法名一样，里边的参数和个数不一样
    //IEnumerable 比list更下一层


    public interface IBaseService<T>: Volo.Abp.Application.Services.IApplicationService where T:class,new()
    {
        //增 、批增
        Task<ServiceResult<T>> InsertAsync(T t);
        Task<ServiceResult<string>> InsertManyAsync(List<T> ts);

        //删、批删
        Task<ServiceResult<string>> DeleteAsync(T t);
        Task<ServiceResult<string>> DeleteManyAsync(List<T> ts);

        //改、批改
        Task<ServiceResult<string>> UpdateAsync(T t);
        Task<ServiceResult<string>> UpdateManyAsync(List<T> ts);

        //显示
        Task<ServiceResult<List<T>>> GetList();

        //查
        Task<ServiceResult<T>> SelectByIDAsync(int id);

   

      
    }
}
