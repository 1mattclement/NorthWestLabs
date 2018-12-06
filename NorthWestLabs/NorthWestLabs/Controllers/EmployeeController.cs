using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Controllers
{
    public class EmployeeController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerList()
        {
            return View(db.Customers.ToList());
        }
    }
}