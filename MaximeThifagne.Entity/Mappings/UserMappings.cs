using AutoMapper;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity.Entities;

namespace MaximeThifagne.Entity.Mappings
{
    public class UserMappings : Profile
    {
        public UserMappings()
        {
            CreateMap<UserEntity, UserDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.UserFirstName, opt => opt.MapFrom(src => src.UserFirstName))
                .ForMember(dest => dest.UserLastName, opt => opt.MapFrom(src => src.UserLastName))
                .ForMember(dest => dest.UserLogin, opt => opt.MapFrom(src => src.Login))
                .ForMember(dest => dest.UserPassword, opt => opt.MapFrom(src => src.Password))
                .ReverseMap();
        }
    }
}
