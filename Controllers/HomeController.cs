using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Partyinvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Partyinvites.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome to the party!";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm ()

        {
            ViewData["Title"] = "RSVPFORM";
            return View();
        }
       [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestresponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddGuest(guestresponse);
                return View("Thanks", guestresponse);
            }
            else
            {
                return View();
            }
        }
       
public ViewResult ListResponses()
        {
            return View(Repository.Adding.Where(r => r.WillAttendParty == true));
        }
        }
            
    }

