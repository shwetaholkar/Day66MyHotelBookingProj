namespace Day66MyHotelBookingProj.Data.Dtos
{
    public class HotelDto
    {
        
        public string Name { get; set; } = null!;

        public string HotelType { get; set; } = null!;

        public int LocationRefId { get; set; }
    }
}
