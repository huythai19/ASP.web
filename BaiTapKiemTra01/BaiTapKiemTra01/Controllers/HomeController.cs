using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiTapKiemTra01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult DangKy(TaiKhoanViewModel model)
 {
     if (model.TenTaiKhoan != null)
     {
         return Content($"Tên Tài Khoản: {model.TenTaiKhoan}, Mật Khẩu: {model.MatKhau}, Họ Tên: {model.HoTen}, Tuổi: {model.Tuoi}");
     }
     return View();
 }
    
 public IActionResult BaiTap2()
 {
		var sanpham = new SanPhamViewModel()
		{
			TenSanPham = "Snack khoai tây",
			GiaBan="5.000.000vnđ",
			AnhMoTa= ""
     };

     return View(sanpham);
 }
    }
}
