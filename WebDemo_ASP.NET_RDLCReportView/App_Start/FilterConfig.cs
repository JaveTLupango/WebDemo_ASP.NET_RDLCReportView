using System.Web;
using System.Web.Mvc;

namespace WebDemo_ASP.NET_RDLCReportView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
