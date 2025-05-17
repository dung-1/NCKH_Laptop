using Microsoft.AspNetCore.Mvc;

namespace NCKH_Laptop.Areas.Admin.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
