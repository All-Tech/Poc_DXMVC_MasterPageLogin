using System.Web;
using System.Web.Mvc;

namespace Poc_DXWebMvcMaterPageLogin {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}