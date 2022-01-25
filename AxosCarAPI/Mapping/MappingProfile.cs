using AxosCarAPI.Controllers.Dto;
using AxosCarAPI.Models;
using AutoMapper;

namespace AxosCarAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, CarDto>();
        }
    }
}
