using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication23.Controllers
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; } 
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            #region dynamic
            //dynamic obj = new ExpandoObject();
            //obj.firstName = "Avrumi";
            //obj.lastName = "Friedman";
            //obj.foo = new Action(() =>
            //{

            //});
            #endregion
            ViewBag.foo = "hello world";
            Person p = new Person
            {
                Name = "Avrumi",
                Age = 36
            };
            ViewBag.Person = p;

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}