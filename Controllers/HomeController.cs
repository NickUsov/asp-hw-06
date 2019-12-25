using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Room room = new Room { Address = "Mira, 25-B", Company = "ITStep", Descript = "Exersize room", Email = "itstep@gmail.org", Fear = 5, Logo = "path_to_logo", MaxPlayers = 20, MinPlayers = 1, MinYears = 16, Phones = "223-322-323-232", Rate = 12.0, Time = "00:05:00", Title = "Room #9", Сomplexity = 5 };

            return View(room);
        }
    }
}