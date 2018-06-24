using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Errors(string message)
        {
            ViewBag.Message = message;
            return View();
        }
        public ActionResult Message(string message)
        {
            ViewBag.Message = message;
            return View();
        }
    }
}