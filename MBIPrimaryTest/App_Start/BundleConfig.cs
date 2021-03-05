using System.Web;
using System.Web.Optimization;

namespace MBIPrimaryTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                "~/lib/jquery/jquery.js", 
                "~/lib/notify.js/notify.js",
                "~/content/sweetalert.min.js"));
        }
    }
}
