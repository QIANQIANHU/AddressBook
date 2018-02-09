using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View();
      }

      [Route("/ContactList")]
      public ActionResult ContactList()
       {
         Contact myContact = new Contact();
         myContact.SetUserName(Request.Query["userName"]);
         myContact.SetPhoneNumber(Request.Query["phoneNumber"]);
         myContact.SetAddress(Request.Query["address"]);
         return View(myContact);
      }

      [Route("/CreateForm")]
      public ActionResult CreateForm()
      {
        return View();
      }

    }
}
