using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models.SchoolViewModels;
using System.Data.Common;

namespace ContosoUniversity.Controllers
{
    public class DisplayFileController : Controller
    {      
       
        private static string InvNumber;
        public DisplayFileController()
        {
        }
        public IActionResult Index()
        {
            //You can uncomment the line below to test message controller works well.
            //return RedirectToAction("Message", "Message", new { message = "Invalid User" });
            return View();
        }
        public async Task<IActionResult> DisplayFile()
        {
            var IsValidUser = false;
            if (IsValidUser == false)
            {
                return RedirectToAction("Message", "Message", new { message = "Invalid User" });
            }
            var memory = new MemoryStream();
            using (var stream = new FileStream(@"C:\Users\xx\Desktop\Bitlocker.pdf", FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/pdf");
        }
    }
}