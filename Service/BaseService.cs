using Daniel_technology.Base;
using Daniel_technology.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Daniel_technology.Service
{
    public class BaseService<T> : Volo.Abp.Application.Services.ApplicationService, IBaseService<T> where T : class, Volo.Abp.Domain.Entities.IEntity<int>, new()
    {
        private readonly IRepository<T,int> _repository;
        public BaseService(IRepository<T,int> repository)
        {
            _repository = repository;
        }

        #region insert

        //添加
        [HttpPost, Route("insert")]
        public async Task<ServiceResult<T>> InsertAsync(T t)
        {
            ServiceResult<T> result = new();
            try
            {
                var m = await _repository.InsertAsync(t);
                result.IsSuccess(m);
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }

            return result;
        }

        //批加
        [HttpPost, Route("insert-many")]
        public async Task<ServiceResult<string>> InsertManyAsync(List<T> ts)
        {
            ServiceResult<string> result = new();
            try
            {
                await _repository.InsertManyAsync(ts);
                result.IsSuccess($"操作成功，批量插入{ts.Count}条数据");
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }
            return result;
        }

        #endregion

        #region delete

        //单删
        [HttpPost, Route("delete")]
        public async Task<ServiceResult<string>> DeleteAsync(T t)
        {
            ServiceResult<string> result = new();
            try
            {
                await _repository.DeleteAsync(t);
                result.IsSuccess("删除成功！");
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }
            return result;
        }

        //批删
        [HttpPost, Route("delete-many")]
        public async Task<ServiceResult<string>> DeleteManyAsync(List<T> ts)
        {
            ServiceResult<string> result = new();
            try
            {
                await _repository.DeleteManyAsync(ts);
                result.IsSuccess($"操作成功，批量删除{ts.Count}条记录");
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }
            return result;
        }

        #endregion

        #region update
        //修改
        [HttpPost, Route("update")]
        public async Task<ServiceResult<string>> UpdateAsync(T t)
        {
            ServiceResult<string> result = new();
            try
            {
                await _repository.UpdateAsync(t);
                result.IsSuccess("操作成功！");
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }

            return result;
        }

        //批改
        [HttpPost, Route("update-many")]
        public async Task<ServiceResult<string>> UpdateManyAsync(List<T> ts)
        {
            ServiceResult<string> result = new();
            try
            {
                await _repository.UpdateManyAsync(ts);
                result.IsSuccess($"操作成功,批量修改了{ts.Count}条数据");
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }

            return result;
        }
        #endregion

        #region select/list

        //查询
        [HttpGet, Route("select")]
        public async Task<ServiceResult<T>> SelectByIDAsync(int id)
        {
            ServiceResult<T> result = new();
            try
            {
                var m = await _repository.GetAsync(id);
                if (m == null)
                {
                    result.IsSuccess("id不存在");
                }
                result.IsSuccess(m);
                return result;
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }
            return result;
        }

        //显示
        [HttpGet, Route("getlist")]
        public async Task<ServiceResult<List<T>>> GetList()
        {
            ServiceResult<List<T>> result = new();
            try
            {
                var m = await _repository.GetListAsync();
                result.IsSuccess(m);
            }
            catch (Exception ex)
            {
                result.IsFailed(ex.Message);
            }
            return result;
        }

        #endregion
    }
}
