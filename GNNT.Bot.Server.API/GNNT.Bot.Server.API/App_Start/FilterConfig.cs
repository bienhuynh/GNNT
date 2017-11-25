using System.Web;
using System.Web.Mvc;

namespace GNNT.Bot.Server.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
