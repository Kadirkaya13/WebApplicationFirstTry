using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationFirstTry.Controllers
{
    public class StudentController : Controller
    {
          public ActionResult Show()
            {
                 ViewBag.MM = "hello"; 
                return View();
            }
    }
}