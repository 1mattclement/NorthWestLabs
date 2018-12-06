using NorthwestLabs.DAL;
using NorthWestLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult WorkOrderList(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WorkOrders workOrders = db.WorkOrders.Find(id);
            if (workOrders == null)
            {
                return HttpNotFound();
            }
            return View(workOrders);
        }
    }
}