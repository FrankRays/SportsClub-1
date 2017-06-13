using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsClub.BusinessLayer;

namespace SportsClub.Controllers
{
    public class SportController : Controller
    {
        // GET: Sport
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sport/Details/5
        public ActionResult Details(string continent)
        {
            SportBL bl = new SportBL();
            ViewBag.Selected = continent;
            return View("SportDetails",bl.GetSports(continent));
        }

        // GET: Sport/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
