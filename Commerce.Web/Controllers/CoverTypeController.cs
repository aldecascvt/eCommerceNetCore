using Commerce.DataAcces;
using Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Web.Controllers
{
    public class CoverTypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.ProductDescription = "";
            IEnumerable<CoverType> objCoverTypeList = _db.CoverTypes;
            return View(objCoverTypeList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _db.CoverTypes.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "CoverType Created Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var objToEdit = _db.CoverTypes.Find(id);
            if (objToEdit == null)
            {
                return NotFound();
            }

            return View(objToEdit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _db.CoverTypes.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "CoverType Updated Successfully";
                return RedirectToAction("Index");

            }
            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null | id == 0)
            {
                return NotFound();
            }
            var objToEdit = _db.CoverTypes.Find(id);
            if (objToEdit == null)
            {
                return NotFound();
            }

            return View(objToEdit);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteObj(int? id)
        {
            var obj = _db.CoverTypes.Find(id);
            if (obj == null)
            {
                NotFound();
            }
            _db.CoverTypes.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "CoverType Deleted Successfully";
            return RedirectToAction("Index");
        }

    }
}
