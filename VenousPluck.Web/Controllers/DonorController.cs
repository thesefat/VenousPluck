using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VenousPluck.Web.Controllers
{
    public class DonorController : Controller
    {
        // GET: Donor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult ListOfDonors()
        {
            return View();
        }
    }
}