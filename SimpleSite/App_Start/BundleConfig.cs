using SimpleSite.Helpers;
using System.Web;
using System.Web.Optimization;

namespace SimpleSite
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

            foreach (var theme in Bootstrap.Themes)
            {
                var stylePath = string.Format("~/Content/Themes/{0}/bootstrap.css", theme);

                bundles.Add(new StyleBundle(Bootstrap.Bundle(theme)).Include(
                            stylePath,
                            "~/Content/bootstrap.custom.css",
                            "~/Content/site.css"));
            }
        }
    }
}
