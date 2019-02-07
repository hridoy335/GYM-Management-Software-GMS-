using System.Web;
using System.Web.Mvc;

namespace GYM_Management_System_G.M.S_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
