using BaiKiemTra02.Data;
using BaiKiemTra02.Data.Migrations;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LopHocController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var lophoc = _db.LopHoc.ToList();
            ViewBag.lophoc = lophoc;
            return View(lophoc);
    
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                _db.LopHoc.Add(lophoc);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.LopHoc.Find(id);

            return View(theloai);
        }
        [HttpPost]
        public IActionResult Edit(Models.LopHoc lophoc)
        {
            if (ModelState.IsValid)
            {
                _db.LopHoc.Update(lophoc);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.LopHoc.Find(id);

            return View(theloai);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var theloai = _db.LopHoc.Find(id);

            return View(theloai);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.LopHoc.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.LopHoc.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
