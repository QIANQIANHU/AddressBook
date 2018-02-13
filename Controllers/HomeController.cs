using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;
using System;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View(ContactVariable.GetAll());
      }

      [HttpGet("/create-form")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult PostContact()
      {
        string name = Request.Form[("userName")];
        string number = Request.Form[("phoneNumber")];
        string address = Request.Form[("address")];
        new ContactVariable(name, number, address);
        return View("Index", ContactVariable.GetAll());
      }

      // [HttpPost("/delete")]
      // public ActionResult DeleteAll()
      // {
      //   //clear the list of all of the objects
      //   //see a confirmation page, with link to adding a new object
      //   //ADDLOGIC
      // }

      //Also want a details route and page

    }
}
