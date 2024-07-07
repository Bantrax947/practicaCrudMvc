using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace practicaCurdMvc.Controllers
{
    public class accessController : Controller
    {
        // GET: access
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Enter(String user, String password)
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error" + ex.Message);
            }
        }
    }
}