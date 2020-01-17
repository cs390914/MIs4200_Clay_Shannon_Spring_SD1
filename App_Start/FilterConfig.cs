using System.Web;
using System.Web.Mvc;

namespace MIs4200_Clay_Shannon_Spring_SD1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
