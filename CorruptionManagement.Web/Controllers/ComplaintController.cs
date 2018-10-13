using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorruptionManagement.Web.Controllers
{
    public class ComplaintController : Controller
    {
        // GET: Complaint
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ticket()
        {
            return View();
        }
    }
}