using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace SimpleSite.Helpers
{
    public class Bootstrap
    {
        public const string BundleBase = "~/Content/css/";
        public static List<string> Themes;

        static Bootstrap()
        {
            var themesFolder = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "Content", "Themes");
            Themes = new List<string>(Directory.GetDirectories(themesFolder).Select(x => Path.GetFileName(x)));
        }

        //public class Theme
        //{
        //    public const string Stock = "Stock";
        //    public const string Cerulean = "Cerulean";
        //    public const string Darkly = "Darkly";
        //}

        //public static List<string> Themes = new List<string>
        //{
        //    Theme.Stock,
        //    Theme.Cerulean,
        //    Theme.Darkly
        //};

        public static string Bundle(string themename)
        {
            return BundleBase + themename;
        }
    }
}