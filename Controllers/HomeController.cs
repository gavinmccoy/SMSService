using System.Web.Mvc;

namespace SMSService.Controllers
{
    public class HomeController : Controller
    {
        // Unused
        public ActionResult Index()
        {
            return View();
        }
        // Basic about page for project
        public ActionResult About()
        {
            ViewBag.Message = "SMS Sender for DIT Assignment";

            return View();
        }

        // Unused
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}