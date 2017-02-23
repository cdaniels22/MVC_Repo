using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/NiceAdmin/css/bootstrap-theme.css",
                      "~/Content/NiceAdmin/css/bootstrap.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/NiceAdmin/css").Include(
                      "~/Content/NiceAdmin/css/elegant-icons-style.css",
                      "~/Content/NiceAdmin/css/font-awesome.css",
                      "~/Content/NiceAdmin/css/font-awesome.min.css",
                      "~/Content/NiceAdmin/css/fullcalendar.css",
                      "~/Content/NiceAdmin/css/line-icons.css",
                      "~/Content/NiceAdmin/css/owl.carousel.css",
                      "~/Content/NiceAdmin/css/style-responsive.css",
                      "~/Content/NiceAdmin/css/style.css",
                      "~/Content/NiceAdmin/css/widgets.css",
                      "~/Content/NiceAdmin/css/xcharts.min.css"));
        }
    }
}
