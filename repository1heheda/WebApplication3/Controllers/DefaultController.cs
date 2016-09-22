using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //try
            //{
            //    throw new Exception("heheh");
            //}
            //catch(Exception e)
            //{
            //    string a = e.ToString();
            //}
            return View();
        }
        public ActionResult PropTest()
        {
            return View();
        }


        
        public ActionResult View1()
        {
         
            test t = new test()
            { id = 1, name = "xx" };
            test t2 = new test()
            { id = 1, name = "yy" };
            test t3 = new test()
            { id = 2, name = "zz" };

            List<test> list = new List<test>();
            list.Add(t);
            list.Add(t2);
            list.Add(t3);

            var a = from i in list select new { xx = i, sum = list.Sum(j => i.id) };
            return View();
        }

        public ActionResult JsValidate()
        {
            return View();
        }

        public ActionResult H5Test()
        {
            return View();
        }
        class test
        {
           public int id { get; set; }
            public string name { get; set; }
        }
        


        public ActionResult DateTimeTest()
        {
            return View();
        }

    }
}