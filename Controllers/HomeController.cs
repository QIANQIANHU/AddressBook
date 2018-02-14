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
      //[HttpGet("/contacts/{id}")] // it's called path parameter
      [HttpGet("/contacts/{id}")]
      public ActionResult ListIndividualContact(int id) {
         List<ContactVariable> contactList = ContactVariable.GetAll();
         for (int i = 0; i < contactList.Count; i++) {
           if (id == contactList[i].GetId()) {
             return View("ContactDetails", contactList[i]);
           }
         }
         return View("Index");
         // Todo: if no matching id, return an error view
      }

    //   [HttpGet("/contacts/{id}")]
    //   public ActionResult ListIndividualContact(int id)
    //  {
    //      Dictionary<string, object> model = new Dictionary<string, object>();
    //      Category selectedCategory = Category.Find(id);
    //      List<Item> categoryItems = selectedCategory.GetItems();
    //      model.Add("category", selectedCategory);
    //      model.Add("items", categoryItems);
    //      return View(model);
    //  }

    }
}
