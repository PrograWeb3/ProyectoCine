using System.Web;
using System.Web.Optimization;

namespace ProyectoCine
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/vendor/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jslib").Include(
                        "~/scripts/vendor/bootbox.js",
                        "~/scripts/vendor/datatables/jquery.datatables.js",
                        "~/scripts/vendor/datatables/datatables.bootstrap.js",
                        "~/scripts/vendor/typeahead.bundle.js",
                        "~/scripts/vendor/toastr.js"
                      ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/vendor/bootstrap.js",
                      "~/Scripts/vendor/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/Site.css"));

            bundles.Add(new StyleBundle("~/Content/csslib").Include(
                      "~/Content/css/datatables/css/datatables.bootstrap.css",
                      "~/Content/css/typeahead.css",
                      "~/Content/css/toastr.css"));
        }
    }
}
