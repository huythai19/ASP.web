using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BaiTapThucHanh_4_9.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Hoten = "Dương Hoàng Thái Huy";
            ViewBag.MSSV = "1822040093";
            ViewBag.Nam = 2024;
            return View();
        }
        public IActionResult MayTinh(string a,string b,string pheptinh)
        {
            double ketqua = 0;
            bool hople = true;

            if (!double.TryParse(a, out double numA) || !double.TryParse(b, out double numB))
            {
                ViewBag.Error = "Dữ liệu nhập vào không hợp lệ. Vui lòng nhập số.";
                ViewBag.HopLe = false;
                return View("MayTinh");
            }
            switch (pheptinh)
            {
                case "cong":
                    ViewBag.ketqua = numA + numB;
                    break;
                case "tru":
                    ViewBag.ketqua = numA - numB;
                    break;
                case "nhan":
                    ViewBag.ketqua = numA * numB;
                    break;
                case "chia":
                    if (numB != 0)
                    {
                        ViewBag.ketqua = numA / numB;
                    }
                    else
                    {
                        ViewBag.Error = "Không thể chia cho 0";
                        hople = false;
                        ViewBag.hople = hople;
                        return View("MayTinh");

                    }
                    break;
                default:
                    ViewBag.Error = "Phép tính không hợp lệ";
                    hople = false;
                    ViewBag.hople = hople;
                    return View("MayTinh");

            }
            return View("Maytinh");
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
}
