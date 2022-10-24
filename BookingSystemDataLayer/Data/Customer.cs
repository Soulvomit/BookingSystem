using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystemDataLayer.Data
{
    public class Customer
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 1, TypeName = "VARCHAR"), StringLength(255), Required]
        public string Firstname { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR"), StringLength(255)]
        public string Lastname { get; set; }

        [Column(Order = 3, TypeName = "DATE")]
        public DateTime Birthdate { get; set; }
    }
}