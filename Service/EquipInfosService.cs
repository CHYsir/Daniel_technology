using Daniel_technology.Base;
using Daniel_technology.Base.Paged;
using Daniel_technology.Dto;
using Daniel_technology.IService;
using Daniel_technology.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Daniel_technology.Service
{
    //[Route("usersssss")]
    public class EquipInfosService:ApplicationService   //IBaseService<EquipInfos>
    {
        IRepository<EquipInfos,int> _repository;
        public EquipInfosService(IRepository<EquipInfos,int> repository)
        {
            _repository = repository;
        }

        #region insert

        //添加
        [HttpPost, Route("insert")]
        public async Task<ServiceResult<EquipInfos>> InsertAsync(EquipInfos t)
        {
            ServiceResult<EquipInfos> result = new();
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
        public async Task<ServiceResult<string>> InsertManyAsync(List<EquipInfos> ts)
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
        public async Task<ServiceResult<string>> DeleteAsync(EquipInfos t)
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
        public async Task<ServiceResult<string>> DeleteManyAsync(List<EquipInfos> ts)
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
        public async Task<ServiceResult<string>> UpdateAsync(EquipInfos t)
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
        public async Task<ServiceResult<string>> UpdateManyAsync(List<EquipInfos> ts)
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
        public async Task<ServiceResult<EquipInfos>> SelectByIDAsync(int id)
        {
            ServiceResult<EquipInfos> result = new();
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
        [HttpPost, Route("getlist")]
        public async Task<ServiceResult<List<EquipInfos>>> GetList()
        {
            ServiceResult<List<EquipInfos>> result = new();
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
        public  async Task<ServiceResult<PagedList<EquipInfos>>> QueryAsync(PagesQueryWhereOrder<EquipInfos> t)
        {
            ServiceResult<PagedList<EquipInfos>> result = new();

            var list = await _repository.GetQueryableAsync();
            if (t.Model != null)
            {
                  Expression<Func<EquipInfos, bool>> where = x => x.EquipName.Contains(t.Model.EquipName);
                list = list.Where(where);
            }
            if (!string.IsNullOrEmpty(t.OrderField))
            {
                Expression<Func<EquipInfos, string>> order = x => x.EquipName;
                if ((bool)t.IsAscending)
                {
                    list = list.OrderBy(order);
                }
                else
                {
                    list = list.OrderByDescending(order);
                }
            }

            PagedList<EquipInfos> pagedList = new(list.Count(), list, t.PageIndex, t.PageSize);
            result.IsSuccess(pagedList);
            return result;
        }
        #endregion




    }
}
