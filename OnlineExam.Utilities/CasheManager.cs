using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OnlineExam.Utilities
{
    public static class CasheManager
    {
        public static void DisableBrowserCache(this HttpContextBase httpContext)
        {
            httpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            httpContext.Response.Cache.SetValidUntilExpires(false);
            httpContext.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            httpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            httpContext.Response.Cache.SetNoStore();
        }
    }
}
