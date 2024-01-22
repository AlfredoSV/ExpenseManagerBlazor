using AutoMapper;
using ExpenseManagerBlazor.Server.Models;
using ExpenseManagerBlazor.Shared.Dtos;

namespace ExpenseManagerBlazor.Server.Mapper
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<UserModel, UserDto>();

        }
    }
}
