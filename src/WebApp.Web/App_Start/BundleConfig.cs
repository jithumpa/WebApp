using System.Web;
using System.Web.Optimization;

namespace WebApp
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/detect.js",
                      "~/Scripts/fastclick.js",
                      "~/Scripts/jquery.blockUI.js",
                      "~/Scripts/waves.js",
                      "~/Scripts/jquery.slimscroll.js",
                      "~/Scripts/jquery.scrollTo.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-select").Include(
                     "~/Scripts/bootstrap-select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                     "~/Scripts/jquery.core.js",
                     "~/Scripts/jquery.app.js"));

            bundles.Add(new ScriptBundle("~/bundles/switchery").Include(
                         "~/Scripts/switchery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/WebApp-alert").Include(
                    "~/Scripts/toastr.min.js",
                    "~/Scripts/WebApp/WebApp-alert.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/core.css",
                      "~/Content/components.css",
                      "~/Content/icons.css",
                      "~/Content/pages.css",
                      "~/Content/menu.css",
                      "~/Content/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/switchery").Include(
                  "~/Content/switchery.min.css"));

            bundles.Add(new StyleBundle("~/Content/WebApp-alert").Include(
                "~/Content/toastr.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-select").Include(                 
                 "~/Content/bootstrap-select.min.css"));
        }
    }
}
