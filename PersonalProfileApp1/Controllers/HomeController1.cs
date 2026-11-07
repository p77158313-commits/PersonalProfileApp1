using Microsoft.AspNetCore.Mvc;

namespace PersonalProfileApp.Controllers
{
    public class InfoController : Controller
    {
        // 1. Басты бет
        public IActionResult Index()
        {
            ViewBag.Message = "Менің жеке портфолио сайтыма қош келдіңіз!";
            ViewBag.FullName = "Жиенбек Пернебек";
            return View();
        }

        // 2. Мен туралы
        public IActionResult About()
        {
            ViewBag.Bio = "Мен бағдарламалау мамандығының студентімін.";
            return View();
        }

        // 3. Портфолио және дағдылар
        public IActionResult Portfolio()
        {
            ViewBag.Skills = "C#, ASP.NET Core MVC, HTML, CSS";
            return View();
        }
    }
}