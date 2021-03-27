using System.Linq;
using System.Web.Mvc;
using WebMVCEntityFramework.Dal;
using WebMVCEntityFramework.Models;

namespace WebMVCEntityFramework.Controllers
{
    public class MealController : Controller
    {
        private MealContext db = new MealContext();

        // GET: Meal
        public ActionResult Index()
        {
            return View(db.Meals.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Meal meal)
        {
            if (ModelState.IsValid)
            {
                db.Meals.Add(meal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meal);
        }

        public ActionResult Edit(int id)
        {
            return View(db.Meals.First(m => m.Id == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Meal meal)
        {
            if (ModelState.IsValid)
            {
                var updateMeal = db.Meals.First(m => m.Id == meal.Id);
                updateMeal.Description = meal.Description;
                updateMeal.Value = meal.Value;
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(meal);
        }

        public ActionResult Details(int id)
        {
            return View(db.Meals.First(m => m.Id == id));
        }

        public ActionResult Delete(int id)
        {
            return View(db.Meals.First(m => m.Id == id));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            var removeMeal = db.Meals.First(m => m.Id == id);
            db.Meals.Remove(removeMeal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}