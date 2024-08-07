using Microsoft.AspNetCore.Mvc;
using LayoutViewExample.Models;

namespace LayoutViewExample.Controllers
{
    public class HomeController : Controller
    {
        //for identifying environment variables 
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [Route("/")]
        public ActionResult Index()
        {
            ViewBag.CurrentEnviornment = _webHostEnvironment.EnvironmentName;
            return View();
        }
        [Route("login")]

        public IActionResult Login()
        {
            ViewData["Title"] = "login";
            ViewBag.Title = "login";
            return View();
        }
        [Route("login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login1()
        {
            return Json("true");
        }
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("contact-us")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("contact-details")]
        public IActionResult ContactDetails()
        {
            ListModel listModel = new ListModel()
            {
                ListTitle = "Contact List",
                ListItems = new List<string>() {
                 "Phone No : 123435646",
                 "Email: abc@gmail.com ",
                 "address: gondal"
                 }
            };
            ViewData["Title"] = "Contact Us";
            return PartialView("_ListPartialView", listModel);
        }
    }
}
