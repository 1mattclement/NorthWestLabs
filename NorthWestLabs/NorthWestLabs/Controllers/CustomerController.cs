using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWestLabs.Models;

namespace NorthWestLabs.Controllers
{
    public class CustomerController : Controller
    {
        private NorthwestLabsContext db = new NorthwestLabsContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WorkList()
        {
            return View(db.WorkOrders.ToList());
        }

        public ActionResult TestList(int? id)
        {
            return View(db.CompoundTests.SqlQuery("SELECT * FROM CompoundTests WHERE WorkOrderID = " + id).ToList());
        }



        public ActionResult CreateWorkOrder()
        {
            return View();
        }
    }
  
}