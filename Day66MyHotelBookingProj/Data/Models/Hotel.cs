using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day66MyHotelBookingProj.Data.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Unicode(false)]
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Unicode(false)]
        [StringLength(100)]
        public string HotelType { get; set; } = null!;  

        public int LocationRefId { get; set; }
        [ForeignKey(nameof(LocationRefId))]
        public Location? Location { get; set; } 
        
    }
}
