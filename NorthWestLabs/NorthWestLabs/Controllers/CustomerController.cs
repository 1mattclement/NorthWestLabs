using NorthwestLabs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthWestLabs.Models;
using System.Data.Entity;

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



        public ActionResult CreateCompound()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCompound([Bind(Include = "LTNumber, CompoundName,Quantity,DateArrived,EmployeeID,DateDue,Appearance, Weight, MolecularMass, MTD")] Compound compound)
        {
            if (ModelState.IsValid)
            {
                db.Compounds.Add(compound);
                db.SaveChanges();
                return RedirectToAction("WorkList");
            }
            return View(compound);
        }


        public ActionResult CreateWorkOrder()
        {
            ViewBag.Customers = db.Customers.ToList();
            ViewBag.LTNumber = db.Compounds.ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWorkOrder([Bind(Include = "WorkOrderID, Comments, RushOrder, CustomerID, PmtInfoID, LTNumber")] WorkOrders workOrders)
        {
               
               
            if (ModelState.IsValid)
            {
                db.WorkOrders.Add(workOrders);
                db.SaveChanges();
                return RedirectToAction("WorkList");
            }
            return View(workOrders);
        }
    }

  
}