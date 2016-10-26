using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CS4790Assignment4.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string VendorName { get; set; }

        [Required]
        [Display(Name = "Card on File")]
        [DataType(DataType.CreditCard)]
        public int CreditCardNumber { get; set; }

        public virtual ICollection<Fruit> Fruits { get; set; }
    }
}