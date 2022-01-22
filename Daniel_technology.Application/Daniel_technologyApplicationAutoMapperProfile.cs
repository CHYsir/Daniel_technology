using AutoMapper;
using Daniel_technology.Dto;
using Daniel_technology.Models;

namespace Daniel_technology;

public class Daniel_technologyApplicationAutoMapperProfile : Profile
{
    public Daniel_technologyApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<UserModel, UserDto>();
        CreateMap<UserDto, UserModel>();

  
    }
}
