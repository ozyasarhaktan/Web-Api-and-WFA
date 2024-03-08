using AutoMapper;

namespace API.Models.DTO
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductDTO>().ReverseMap();
            //CreateMap<ProductDTO,Product>();
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }

    }
}
