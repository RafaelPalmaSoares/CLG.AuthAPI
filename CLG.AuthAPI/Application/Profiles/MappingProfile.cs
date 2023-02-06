using AutoMapper;
using CLG.AuthAPI.Application.Command.Response;
using CLG.AuthAPI.Application.Models;

namespace CLG.AuthAPI.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<SignInResponse, User>().ReverseMap();
        }
    }
}
