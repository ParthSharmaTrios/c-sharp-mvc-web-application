using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMvc
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult  Index()
        {
            return View();
        }

        public ActionResult Leadership()
        {
            return View();

        }
    }
}