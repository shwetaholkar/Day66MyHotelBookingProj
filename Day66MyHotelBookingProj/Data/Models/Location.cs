using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day66MyHotelBookingProj.Data.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(100)]
        public string Name { get; set; } = null!;
    }
}

