using System.Web;
using System.Web.Mvc;

namespace 新闻系统存储过程
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}