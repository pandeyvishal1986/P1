using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckUnity.Models;
using SchoolDataLayer;
using ServiceLocation;

namespace CheckUnity.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //using (var ctx = new SchoolDBContext())
            //{
            //    var stud = new Student() { StudentName = "Bill2" };

            //    ctx.Students.Add(stud);
            //    ctx.SaveChanges();
            //}
            return View();
        }
    }
}