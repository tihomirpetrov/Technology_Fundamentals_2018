namespace CatShop.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using CatShop.Models;
    using System.Linq;

    public class CatController : Controller
    {
        private readonly CatDbContext context;

        public CatController(CatDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new CatDbContext())
            {
                var allCats = db.Cats.ToList();
                return View(allCats);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(string name, string nickname, double price)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(nickname))
            {
                return RedirectToAction("Index");
            }

            Cat cat = new Cat
            {
                Name = name,
                Nickname = nickname,
                Price = price
            };

            using (var db = new CatDbContext())
            {
                db.Cats.Add(cat);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var db = new CatDbContext())
            {
                var catToEdit = db.Cats.FirstOrDefault(t => t.Id == id);
                if (catToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(catToEdit);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Cat catModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new CatDbContext())
            {
                var catToEdit = db.Cats.FirstOrDefault(t => t.Id == catModel.Id);
                catToEdit.Name = catModel.Name;
                catToEdit.Nickname = catModel.Nickname;
                catToEdit.Price = catModel.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new CatDbContext())
            {
                Cat catDetails = db.Cats.FirstOrDefault(t => t.Id == id);
                if (catDetails == null)
                {
                    RedirectToAction("Index");
                }
                return View(catDetails);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Cat catModel)
        {
            using (var db = new CatDbContext())
            {
                if (catModel == null)
                {
                    RedirectToAction("Index");
                }
                db.Cats.Remove(catModel);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
