using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Model;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();
            CreateMap<Product, ProductWtihCategoryDto>();
            CreateMap<Category, CategoryWithProductDto>();
        }
    }
}
