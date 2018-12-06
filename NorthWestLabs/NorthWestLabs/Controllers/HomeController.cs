using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NorthWestLabs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            if(string.Equals(username, "employee") && (string.Equals(password, "employee")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);
                return RedirectToAction("EmployeeInfo", "Home"); //fix
            }
            else if (string.Equals(username, "customer") && (string.Equals(password, "customer")))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);
                return RedirectToAction("CustomerInfo", "Home"); //fix
            }
            else
            {
                return View();
            }

        }

        [Authorize]
        public ActionResult EmployeeInfo()
        {
            return RedirectToAction("Index", "Employee");
        }

        [Authorize]
        public ActionResult CustomerInfo()
        {
            return RedirectToAction("Index", "Customer");
        }
    }
}