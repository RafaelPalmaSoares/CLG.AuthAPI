using AutoMapper;
using CLG.AuthAPI.Application.Command.Response;
using CLG.AuthAPI.Application.Models;

namespace CLG.AuthAPI.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<SignInResponse, User>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => $"{src.Id}"))
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => $"{src.Username}"));
        }
    }
}
