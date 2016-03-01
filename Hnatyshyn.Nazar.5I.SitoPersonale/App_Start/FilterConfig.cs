using System.Web;
using System.Web.Mvc;

namespace Hnatyshyn.Nazar._5I.SitoPersonale
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
