using Microsoft.AspNetCore.Mvc;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() { return View(); }
        public ViewResult About() { return View(); }
        public ViewResult Contact() { return View(); }

    }
}
