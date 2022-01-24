using Daniel_technology.Base;
using Daniel_technology.Dto;
using Daniel_technology.IService;
using Daniel_technology.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Daniel_technology.Service
{
    public class LoginService: Volo.Abp.Application.Services.ApplicationService, ILoginService
    {
        //依赖注入
        private readonly IRepository<UserModel, int> _repository;
        public LoginService(IRepository<UserModel, int> repository)
        {
            _repository = repository;
        }

        #region 增改查

        //添加用户
        [HttpPost,Route("adduser")]
        public async Task<ServiceResult<string>> AddUser(UserDto model)
        {

            var result = new ServiceResult<string>();

            var entity = new UserModel
            {
                UserName = model.UserName,
                UserPwd = model.UserPwd,
                Detailed = model.Detailed,
                LgoinStatus = model.LgoinStatus,
                Sex = model.Sex,
                UserAccount = model.UserAccount,
                UserPhone = model.UserPhone
            };

            var usermodel = await _repository.InsertAsync(entity);
            if (usermodel == null)
            {
                result.IsFailed("添加失败");
                return result;
            }

            result.IsSuccess("添加成功");
            return result;
        }

        //用户显示
        [HttpGet,Route("getlist")]
        public async Task<List<UserDto>> GetList()
        {
            var list = await _repository.GetListAsync();
            var getlist = ObjectMapper.Map<List<UserModel>, List<UserDto>>(list);
            return getlist;
        }

        //查询id
        [HttpGet,Route("cx")]
        public async Task<ServiceResult<UserDto>> SelectList(int id)
        {
            var result = new ServiceResult<UserDto>();
            var usermodel = await _repository.GetAsync(id);
            if (usermodel == null)
            {
                result.IsFailed("id不存在");
                return result;
            }

            var dto = new UserDto
            {
                UserName = usermodel.UserName,
                UserPwd = usermodel.UserPwd,
                Detailed = usermodel.Detailed,
                LgoinStatus = usermodel.LgoinStatus,
                Sex = usermodel.Sex,
                UserAccount = usermodel.UserAccount,
                UserPhone = usermodel.UserPhone
            };

            result.IsSuccess(dto);
            return result;
        }

        //删除
        [HttpPost, Route("deleteuser")]
        public async Task<ServiceResult> DeleteUser(int id)
        {
            var result = new ServiceResult();
            if(id>=1)
            {
                await _repository.DeleteAsync(id);
                result.IsSuccess("删除成功！");
            }
            else
            {
                result.IsFailed("删除失败");
            }
            return result;
        }

        //修改
        [HttpPost, Route("updateuser")]
        public async Task<ServiceResult<string>> UpdateUser(int id, UserDto model)
        {
            var result = new ServiceResult<string>();

            var usermodel = await _repository.GetAsync(id);
            if (usermodel == null)
            {
                result.IsFailed("数据不存在");
                return result;
            }

            usermodel.UserName = model.UserName;
            usermodel.UserPwd = model.UserPwd;
            usermodel.Detailed = model.Detailed;
            usermodel.LgoinStatus = model.LgoinStatus;
            usermodel.Sex = model.Sex;
            usermodel.UserAccount = model.UserAccount;
            usermodel.UserPhone = model.UserPhone;

            await _repository.UpdateAsync(usermodel);

            result.IsSuccess("更新成功");
            return result;
        }

        #endregion

        #region 登录

        [HttpPost, Route("login")]
        public async Task<ServiceResult<UserDto>> Login(UserDto model)
        {

            var list = await _repository.GetListAsync();
            //判断用户名和密码是否为空
            if (!string.IsNullOrEmpty(model.UserName) || !string.IsNullOrEmpty(model.UserPwd))
            {
                var gets = list.Where(x => x.UserName.Equals(model.UserName) && x.UserPwd.Equals(model.UserPwd)).ToList();


                if (gets.Count > 0)
                {
                    return new ServiceResult<UserDto>
                    {
                        Code = Base.Enum.ServiceResultCode.Succeed,
                        Token = Jwt.Create.CreateToken(model.UserName),
                        Message = "成功"
                    };
                }
            }

            return new ServiceResult<UserDto>
            {
                Code = Base.Enum.ServiceResultCode.Failed,
                Message = "失败"
            };

        }
        #endregion


    }
}
