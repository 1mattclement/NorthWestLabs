using NorthwestLabs.DAL;
using NorthWestLabs.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WorkOrders workOrders = db.WorkOrders.Find(id);

            if (workOrders == null)
            {
                return HttpNotFound();
            }
            return View(db.WorkOrders.SqlQuery("SELECT * FROM WorkOrders WHERE CustomerID = " + id).ToList());
        }

        public ActionResult CompoundTestList(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CompoundTests compoundTests = db.CompoundTests.Find(id);

            if (compoundTests == null)
            {
                return HttpNotFound();
            }
            return View(db.CompoundTests.SqlQuery("SELECT * FROM CompoundTests WHERE WorkOrderID = " + id).ToList());
        }

        public ActionResult EditTest(int? id)
        {
            ViewBag.Status = db.Statuses.ToList();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CompoundTests compoundTests = db.CompoundTests.Find(id);

            if (compoundTests == null)
            {
                return HttpNotFound();
            }
            return View(compoundTests);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditTest([Bind(Include = "TestID, LTNumber, SampleID, TestTypeID, EmployeeID, StatusID, WorkOrderID")] CompoundTests compoundTests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compoundTests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("EditTest");
            }
            return View(compoundTests);
        }

    }
}