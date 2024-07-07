using System.Web;
using System.Web.Mvc;

namespace practicaCurdMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Filters.vefifySession());//se da de alta la clase para que se ejecute
        }
    }
}
