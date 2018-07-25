using System.Web;
using System.Web.Optimization;

namespace MovieDatabase
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //Adding all the script and library//


            //Angular javascript library downloaded from website and then added in this bundle //
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/lib/Angular/angular.min.js"));

            //Movie controller//
            bundles.Add(new ScriptBundle("~/bundles/angular-movie-controller").Include(
                      "~/Scripts/JsController/MovieController.js"));

            //Movie Css page
            bundles.Add(new StyleBundle("~/Content/moviecss").Include(
                     "~/Content/movie.css"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
