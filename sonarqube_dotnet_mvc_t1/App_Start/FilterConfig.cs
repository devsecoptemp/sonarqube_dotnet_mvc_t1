using System.Web;
using System.Web.Mvc;

namespace sonarqube_dotnet_mvc_t1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
