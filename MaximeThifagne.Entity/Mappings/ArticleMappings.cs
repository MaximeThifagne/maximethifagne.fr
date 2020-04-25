using AutoMapper;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity.Entities;

namespace MaximeThifagne.Entity.Mappings
{
    public class ArticleMappings : Profile
    {
        public ArticleMappings()
        {
            CreateMap<ArticleEntity, ArticleDto>()
                .ForMember(dest => dest.ArticleId, opt => opt.MapFrom(src => src.ArticleId))
                .ForMember(dest => dest.ArticleTitle, opt => opt.MapFrom(src => src.ArticleTitle))
                .ForMember(dest => dest.ArticleBody, opt => opt.MapFrom(src => src.ArticleBody))
                .ForMember(dest => dest.ArticlePhoto, opt => opt.MapFrom(src => src.ArticlePhoto))
                .ForMember(dest => dest.ArticleSource, opt => opt.MapFrom(src => src.ArticleSource))
                .ForMember(dest => dest.ArticleSourceLink, opt => opt.MapFrom(src => src.ArticleSourceLink))
                .ForMember(dest => dest.ArticleCreationDate, opt => opt.MapFrom(src => src.ArticleCreationDate))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category))
                .ReverseMap();
        }
    }
}
