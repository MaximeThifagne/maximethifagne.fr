using AutoMapper;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity.Entities;

namespace MaximeThifagne.Entity.Mappings
{
    public class SubArticleMappings : Profile
    {
        public SubArticleMappings()
        {
            CreateMap<SubArticleEntity, SubArticleDto>()
                .ForMember(dest => dest.SubArticleId, opt => opt.MapFrom(src => src.SubArticleId))
                .ForMember(dest => dest.SubArticleTitle, opt => opt.MapFrom(src => src.SubArticleTitle))
                .ForMember(dest => dest.SubArticleBody, opt => opt.MapFrom(src => src.SubArticleBody))
                .ForMember(dest => dest.SubArticlePhoto, opt => opt.MapFrom(src => src.SubArticlePhoto))
                .ReverseMap();
        }
    }
}
