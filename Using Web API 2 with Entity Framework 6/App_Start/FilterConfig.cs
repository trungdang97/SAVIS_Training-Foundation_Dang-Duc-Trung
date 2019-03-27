using System.Web;
using System.Web.Mvc;

namespace Using_Web_API_2_with_Entity_Framework_6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
