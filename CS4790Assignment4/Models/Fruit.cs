using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CS4790Assignment4.Models
{
    public class Fruit
    {
        public int FruitID { get; set; }
        public string FruitTitle { get; set; }
        public string Contributor { get; set; }

        [Range(1, 100)]
        public int Popularity { get; set; }

        
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]   // money datatype in sqlserver   smallmoney also an option
        public decimal Price { get; set; }

        [DataType(DataType.ImageUrl)]
        public string FruitPic { get; set; }

        public int? VendorID { get; set; }

        public virtual Vendor Vendors { get; set; }
    }

  
}