using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CS4790Assignment4.Models;
using CS4790Assignment4.DAL;
using PagedList; //pagedlist.mvc from nuget


namespace CS4790Assignment4.Controllers
{
    public class FruitsController : Controller
    {
        private FruitDBContext db = new FruitDBContext();

        // GET: Fruits
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.TitleSortParm = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.ContSortParm = sortOrder == "cont" ? "cont_desc" : "Cont";
            ViewBag.PopularitySortParm = sortOrder == "popularity" ? "popularity_desc" : "Popularity";


            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var fruit = from s in db.Fruits
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                fruit = fruit.Where(s => s.FruitTitle.ToUpper().Contains(searchString.ToUpper()) || s.Contributor.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    fruit = fruit.OrderByDescending(s => s.FruitTitle);
                    break;
                case "Cont":
                    fruit = fruit.OrderBy(s => s.Contributor);
                    break;
                case "cont_desc":
                    fruit = fruit.OrderByDescending(s => s.Contributor);
                    break;
                case "popularity_desc":
                    fruit = fruit.OrderByDescending(s => s.Popularity);
                    break;
                case "popularity":
                    fruit = fruit.OrderBy(s => s.Popularity);
                    break;
                default:
                    fruit = fruit.OrderBy(s => s.FruitTitle);
                    break;
            }

            int pageSize = 4; // only show 4 results per page
            int pageNumber = (page ?? 1); // if page has value assign that else 1



            return View(fruit.ToPagedList(pageNumber, pageSize));
        }

        // GET: Fruits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // GET: Fruits/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Fruits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FruitTitle,Contributor,Popularity,Price,FruitPic")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Fruits.Add(fruit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruit);
        }

        // GET: Fruits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FruitTitle,Contributor,Popularity,Price,FruitPic")] Fruit fruit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruit);
        }

        // GET: Fruits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fruit fruit = db.Fruits.Find(id);
            if (fruit == null)
            {
                return HttpNotFound();
            }
            return View(fruit);
        }

        // POST: Fruits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fruit fruit = db.Fruits.Find(id);
            db.Fruits.Remove(fruit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
