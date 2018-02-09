using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
       {
         ContactVariable myContactvariable = new ContactVariable();
         myContactvariable.SetUserName(Request.Query["userName"]);
         myContactvariable.SetPhoneNumber(Request.Query["phoneNumber"]);
         myContactvariable.SetAddress(Request.Query["address"]);
         return View(myContactvariable);
      }

      [Route("/CreateForm")]
      public ActionResult CreateForm()
      {
        return View();
      }
    }
}
