using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CS4790Assignment4.Models
{
    public class Fruit
    {
        public int ID { get; set; }
        public string FruitTitle { get; set; }
        public string Contributor { get; set; }
        [Range(1, 100)]
        public int Popularity { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [DataType(DataType.ImageUrl)]
        public string FruitPic { get; set; }
    }

    public class FruitDBContext :DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
    }
}