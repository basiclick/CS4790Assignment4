namespace CS4790Assignment4.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<CS4790Assignment4.DAL.FruitDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CS4790Assignment4.DAL.FruitDBContext context)
        {



    //        var vendors = new List<Vendor>
    //        {
    //            new Vendor{FirstName = "Wesley", LastName ="Snipes",
    //            VendorName = "Hollywood Fruits", CreditCardNumber = 1234},
    //            new Vendor{FirstName = "Gene", LastName ="Wilder",
    //            VendorName = "WonkaFruits", CreditCardNumber = 3384},
    //            new Vendor{FirstName = "Beltugeuse", LastName ="DeConte",
    //            VendorName = "Fantasy Fruits", CreditCardNumber = 6544}
    //        };
    //        vendors.ForEach(s => context.Vendors.AddOrUpdate(p => p.VendorID, s));
    //        context.SaveChanges();

    //        var fruits = new List<Fruit>
    //        {
    //            new Fruit{ FruitTitle = "peach", Contributor = "paul olson",
    //            Popularity= 44, Price= 4, FruitPic="https://encrypted-tbn2.gstatic.com/images?q=tbn:and9gcstxh3uhk4u4-sxoyq4v0ooj24auk50-kdepmygjuyj9d_sotacga",
    //            VendorID = vendors.Single(s =>s.VendorName == "Fantasy Fruits").VendorID},
    //            new Fruit{ FruitTitle= "plum", Contributor = "mark hamilton",
    //            Popularity= 9, Price= 18, FruitPic="https://encrypted-tbn2.gstatic.com/images?q=tbn:and9gcshhfgpa9k0r1l5o7idyi6cv1phvulkdcjfqebkj_puemn2soq8",
    //            VendorID = vendors.Single(s =>s.VendorName == "Fantasy Fruits").VendorID},
    //            new Fruit{ FruitTitle = "watermelon", Contributor = "jafar",
    //            Popularity= 78, Price= 28, FruitPic= "https://encrypted-tbn0.gstatic.com/images?q=tbn:and9gcrjugreo-1xwul9n1mqihcgju3wa0ukxxqmkshnltshbbadvi1vag",
    //            VendorID = vendors.Single(s =>s.VendorName == "Fantasy Fruits").VendorID},
    //            new Fruit{FruitTitle = "grapes", Contributor ="magic johnson",
    //            Popularity= 95, Price= 12, FruitPic= "https://encrypted-tbn0.gstatic.com/images?q=tbn:and9gcskgm36roud-qbe2cliz19j-8t0rawdce37govwsht8c2t-hkrg",
    //            VendorID = vendors.Single(s =>s.VendorName == "Hollywood Fruits").VendorID },
    //            new Fruit{FruitTitle = "apple", Contributor ="hula hooper",
    //            Popularity= 45, Price= 25, FruitPic= "https://encrypted-tbn3.gstatic.com/images?q=tbn:and9gcqk6gq0b5s2cvqyc_q9ykqpcuzmikh2d_xl4uusfxswwxgkuyena_daha",
    //            VendorID = vendors.Single(s =>s.VendorName == "Hollywood Fruits").VendorID},
    //            new Fruit{FruitTitle = "cantaloupe", Contributor ="paul olson",
    //            Popularity= 37, Price= 15, FruitPic= "https://encrypted-tbn2.gstatic.com/images?q=tbn:and9gcq8zch4vh0njfk5lifn5di5zko4bhimevwbfypvwjpc4akkujtr",
    //            VendorID = vendors.Single(s =>s.VendorName == "Hollywood Fruits").VendorID},
    //            new Fruit{FruitTitle = "pear", Contributor ="hula hooper",
    //            Popularity= 55, Price= 78, FruitPic= "https://encrypted-tbn2.gstatic.com/images?q=tbn:and9gcr77yddzzddl2pe3diy710llznaxsq5f41unvnbpaet9tn7j7zg",
    //            VendorID = vendors.Single(s =>s.VendorName == "WonkaFruits").VendorID},
    //            new Fruit{FruitTitle = "cherry", Contributor ="frank enstein",
    //            Popularity= 96, Price= 34, FruitPic= "https://encrypted-tbn0.gstatic.com/images?q=tbn:and9gcstbxtl9czq7mawfjbzf6iqvxqhck_lh3ux3xcpo0yf_vbpd0s4xa",
    //            VendorID = vendors.Single(s =>s.VendorName == "WonkaFruits").VendorID},
    //            new Fruit{FruitTitle = "lime", Contributor ="hula hooper",
    //            Popularity= 49, Price= 5, FruitPic= "https://encrypted-tbn3.gstatic.com/images?q=tbn:and9gcq-1corkh7bfliiasas_ji8argnf3ktyhzsafszjjsufksej0-crnlgzq",
    //            VendorID = vendors.Single(s =>s.VendorName == "WonkaFruits").VendorID},
    //            new Fruit{FruitTitle = "pineapple", Contributor ="frank enstein",
    //            Popularity= 35, Price= 47, FruitPic= "https://encrypted-tbn2.gstatic.com/images?q=tbn:and9gcsxtoyzgmosvnkxe7lclvlxocq6rwown8utcraneq5j788wi3hakg",
    //            VendorID = vendors.Single(s =>s.VendorName == "WonkaFruits").VendorID},
    //            new Fruit{FruitTitle = "kiwi", Contributor ="jafar",
    //            Popularity= 67, Price= 19, FruitPic= "https://encrypted-tbn1.gstatic.com/images?q=tbn:and9gcs_x_chtqvsyqhylcjjfdpmq02cnw6_jygeaqqlrdcknco9vevwxw",
    //            VendorID = vendors.Single(s =>s.VendorName == "WonkaFruits").VendorID}
    //        };

    //        fruits.ForEach(s => context.Fruits.AddOrUpdate(p => p.FruitID, s));
    //        context.SaveChanges();
      }
    }
}
