using System;
using System.Web.Mvc;
using SMSService.Models;
namespace SMSService.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        // Returns list of contacts
        public ActionResult Index()
        {
            Contacts contactsIndex = new Contacts();
            return View(contactsIndex.contacts);
        }
        
        // Sends area code and phone number to SMSTextMessage/Index
        public ActionResult SendMessage(String AreaCode, String PhoneNumber)
        {
            SMSTextMessage sms = new SMSTextMessage();
            AreaCode = sms.AreaCode;
            PhoneNumber = sms.PhoneNumber;
            return View("~/Views/SMSTextMessage/Index.cshtml", sms);
        }
    }
}