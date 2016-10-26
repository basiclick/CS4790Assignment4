using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CS4790Assignment4.Models;

namespace CS4790Assignment4.ViewModels
{
    public class VendorFruits
    {
        public IEnumerable<Fruit> Fruits { get; set; }
        public IEnumerable<Vendor> Vendors { get; set; }
    }
}