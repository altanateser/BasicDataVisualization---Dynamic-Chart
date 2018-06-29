using Layer.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layer.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            dKatman db = new dKatman();

            List<Employees> emp = db.calisanListesi();

            var listOfAge = emp.Select(x => x.Age).Distinct();

            List<int> liste = new List<int>();


            foreach (var item in listOfAge)
            {
                liste.Add(emp.Count(x => x.Age == item));
            }
             
           
            var ddl = liste; 
            
            ViewBag.AGE = listOfAge;
            ViewBag.DDL = ddl.ToList();

            return View();
        }

        public ActionResult First()
        {
            return View();
        }
    }
}