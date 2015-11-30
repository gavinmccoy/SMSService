using System.Web.Mvc;
using SMSService.Models;
namespace SMSService.Controllers
{
    public class SMSTextMessageController : Controller
    {
        // GET: SMSTextMessage
        public ActionResult Index()
        {
            return View();
        }

        // POST: SMSTextMessage
        [HttpPost]
        public ActionResult Index(SMSTextMessage sms)
        {
            if (ModelState.IsValid)
            {
                // findContact returns error, an error message is broadcast to the screen.
                // otherwise it broadcasts a success message
                    Contacts contactsIndex = new Contacts();
                    string findContact = contactsIndex.findContact(sms.AreaCode, sms.PhoneNumber);

                    if (findContact == "error")
                    {
                        ViewData["SuccessMsg"] = "Error. Contact does not exist. Goto contacts page above.";
                    }
                    else
                    {
                        ViewData["SuccessMsg"] = "Message was successfully sent.";
                    }
            }
            return View(sms);
        }
    }
}