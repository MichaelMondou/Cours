using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemple1.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult TestContent()
        {
            string data = "<h1>Test de Content Result.</h1>";
            return Content(data, "text/html");
        }

        public string TestString()
        {
            string txt = "Hello world !";
            return txt;
        }

        public EmptyResult TestEmpty()
        {
            return null;
        }
    }
}