using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practicaCurdMvc;
using practicaCurdMvc.Controllers;
using practicaCurdMvc.Models;

namespace practicaCurdMvc.Filters
{
    public class vefifySession : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)//este filtro entra antes del controller al por el override
        {
            var oUser = (Usuario)HttpContext.Current.Session["User"];//se evañua la sesión
            if (oUser == null)//datos son nulo
            {
                if (filterContext.Controller is accessController == false)// Condición: se usa para que no entre en un blucle de redirreccion si es nulo, ya que el login
                {
                    filterContext.HttpContext.Response.Redirect("~/access/Index");//redireccion de sesión
                }
            }
            else
            {
                if (filterContext.Controller is accessController == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");//redireccion de sesión
                }
            }


            base.OnActionExecuted(filterContext);
        }
    }
}