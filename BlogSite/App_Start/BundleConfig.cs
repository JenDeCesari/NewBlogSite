using System.Web.Optimization;

namespace TwitterBootstrapPresentation
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //JavaScript Bundles

            bundles.Add(new ScriptBundle("~/jquery").Include("~/Scripts/jquery-1.*"));
            bundles.Add(new ScriptBundle("~/jqmobile").Include("~/Scripts/jquery.mobile*"));
            bundles.Add(new ScriptBundle("~/TwitterBootstrap").Include("~/Scripts/bootstrap*"));

            //CSS Bundles

            bundles.Add(new StyleBundle( "~/site").Include("~/Content/site.css"));
            bundles.Add(new StyleBundle( "~/JQueryMobileCSS").IncludeDirectory("~/Content/", "JQuery.mobile*.css", false));
            bundles.Add(new StyleBundle( "~/TwitterBootstrapCSS").Include("~/Content/bootstrap.css","~/Content/bootstrap-responsive.css"));
            bundles.Add(new StyleBundle( "~/TwitterBootstrapCSSoverride").Include("~/Content/bootstrap-override.css"));
            
            
        }
    }
}