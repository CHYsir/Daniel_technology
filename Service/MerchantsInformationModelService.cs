using Daniel_technology.Base;
using Daniel_technology.Base.Paged;
using Daniel_technology.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Daniel_technology.Service
{
    [Route("merchantsInformation")]
    public class MerchantsInformationModelService: ApplicationService
    {
        IRepository<MerchantsInformationModel, int> _repository;
        public MerchantsInformationModelService(IRepository<MerchantsInformationModel, int> repository)
        {
            _repository = repository;
        }

        #region insert

        //添加
        [HttpPost, Route("insert")]
        public async Task<ServiceResult<MerchantsInformationModel>> InsertAsync(MerchantsInformationModel t)
        {
            ServiceResult<MerchantsInformationModel> result = new();
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
        public async Task<ServiceResult<string>> InsertManyAsync(List<MerchantsInformationModel> ts)
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
        public async Task<ServiceResult<string>> DeleteAsync(MerchantsInformationModel t)
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
        public async Task<ServiceResult<string>> DeleteManyAsync(List<MerchantsInformationModel> ts)
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
        public async Task<ServiceResult<string>> UpdateAsync(MerchantsInformationModel t)
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
        public async Task<ServiceResult<string>> UpdateManyAsync(List<MerchantsInformationModel> ts)
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
        public async Task<ServiceResult<MerchantsInformationModel>> SelectByIDAsync(int id)
        {
            ServiceResult<MerchantsInformationModel> result = new();
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
        [HttpGet,Route("getlist")]
        public async Task<ServiceResult<List<MerchantsInformationModel>>> GetList()
        {
            ServiceResult<List<MerchantsInformationModel>> result = new();
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

        #region query

        [HttpPost, Route("query")]
        public async Task<ServiceResult<PagedList<MerchantsInformationModel>>> QueryAsync(PagesQueryWhereOrder<MerchantsInformationModel> t)
        {
            ServiceResult<PagedList<MerchantsInformationModel>> result = new();

            var list = await _repository.GetQueryableAsync();
            if (t.Model != null)
            {
                Expression<Func<MerchantsInformationModel, bool>> where = x => x.MerchantsName.Contains(t.Model.MerchantsName);
                list = list.Where(where);
            }
            if (!string.IsNullOrEmpty(t.OrderField))
            {
                Expression<Func<MerchantsInformationModel, string>> order = x => x.MerchantsName;
                if ((bool)t.IsAscending)
                {
                    list = list.OrderBy(order);
                }
                else
                {
                    list = list.OrderByDescending(order);
                }
            }

            PagedList<MerchantsInformationModel> pagedList = new(list.Count(), list, t.PageIndex, t.PageSize);
            result.IsSuccess(pagedList);
            return result;
        }
        #endregion
    }
}
