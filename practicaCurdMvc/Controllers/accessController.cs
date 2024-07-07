using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using practicaCurdMvc.Models;

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
                using (practicaMvcEntity db= new practicaMvcEntity())
                {
                    var lst = from d in db.Usuario
                              where d.email == user && d.password == password && d.idState == 1
                              select d;

                    if (lst.Count() > 0) {
                        
                        Session["User"] =lst.First();
                        return Content("1");

                    }
                    else
                    {
                        return Content("Usuario No Aceptado");
                    }
                }

              
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error" + ex.Message);
            }
        }
    }
}