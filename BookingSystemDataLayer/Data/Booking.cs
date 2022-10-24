using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystemDataLayer.Data
{
    public class Booking
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 1), Required]
        public virtual Customer Customer { get; set; }

        [Column(Order = 2), Required]
        public virtual Employee Employee { get; set; }

        [Column(Order = 3, TypeName = "DATE"), Required]
        public DateTime Date { get; set; }

        [Column(Order = 4), Required]
        public TimeSpan Start { get; set; }

        [Column(Order = 5), Required]
        public TimeSpan End { get; set; }
    }
}
