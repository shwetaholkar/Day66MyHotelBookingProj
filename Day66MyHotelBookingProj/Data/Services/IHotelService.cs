using Day66MyHotelBookingProj.Data.Dtos;

namespace Day66MyHotelBookingProj.Data.Services
{
    public interface IHotelService
    {
        Task<List<HotelDto>> GetAllAsync();
        Task<HotelDto> GetByIdAsync(int id);
        Task CreateAsync(HotelDto hotelDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(HotelDto hotelDto);
       
    }
}

