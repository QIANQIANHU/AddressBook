using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Hello()
       {
         AddressVariable myAddressVariable = new AddressVariable();
         myAddressVariable.SetUserName(Request.Query["userName"]);
         myAddressVariable.SetPhoneNumber(Request.Query["phoneNumber"]);
         myAddressVariable.SetAddress(Request.Query["address"]);
         return View(myAddressVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      // [Route("/")]
      //   public ActionResult GreetingCard()
      //   {
      //       LetterVariable myLetterVariable = new LetterVariable();
      //       myLetterVariable.SetRecipient(Request.Query["userName"]);
      //       myLetterVariable.SetSender(Request.Query["sender"]);
      //       return View("Hello", myLetterVariable);
      //   }

      // [Produces("text/html")]
      // [Route("/favorite_photos")]
      // public ActionResult FavoritePhotos()
      // {
      //   return View();
      // }

    }
}
