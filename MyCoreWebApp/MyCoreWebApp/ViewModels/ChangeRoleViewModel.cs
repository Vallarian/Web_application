using Microsoft.AspNetCore.Mvc;

namespace MyCoreWebApp.ViewModels
{
    public class ChangeRoleViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
