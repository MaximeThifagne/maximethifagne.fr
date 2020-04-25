using AutoMapper;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity.Entities;

namespace MaximeThifagne.Entity.Mappings
{
    public class CommentMappings : Profile
    {
        public CommentMappings()
        {
            CreateMap<CommentEntity, CommentDto>()
                .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.CommentId))
                .ForMember(dest => dest.CommentatorName, opt => opt.MapFrom(src => src.CommentatorName))
                .ForMember(dest => dest.CommentatorEmail, opt => opt.MapFrom(src => src.CommentatorEmail))
                .ForMember(dest => dest.CommentatorWebSite, opt => opt.MapFrom(src => src.CommentatorWebSite))
                .ForMember(dest => dest.CommentMessage, opt => opt.MapFrom(src => src.CommentMessage))
                .ForMember(dest => dest.CommentDate, opt => opt.MapFrom(src => src.CommentCreationDate))
                .ReverseMap();
        }
    }
}
