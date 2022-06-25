using AutoMapper;
using Day66MyHotelBookingProj.Data.Dtos;
using Day66MyHotelBookingProj.Data.Models;

namespace Day66MyHotelBookingProj
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
