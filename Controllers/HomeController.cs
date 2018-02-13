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

      [HttpPost("/delete")]
      public ActionResult DeleteAll()
      {
        ContactVariable.ClearAll();
        return View();
      }

      //Also want a details route and page

    }
}
