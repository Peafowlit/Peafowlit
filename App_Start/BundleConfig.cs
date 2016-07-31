using System.Web;
using System.Web.Optimization;

namespace PeafowlIT_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/js/jquery.js",
                        "~/js/jquery-ui.js",
                        "~/js/jquery-migrate.min.js",
                        "~/rs-plugin/js/jquery.themepunch.tools.min.js",
                        "~/rs-plugin/js/jquery.themepunch.revolution.min.js",
                        "~/js/prettify.js",
                        "~/js/jquery.carouFredSel-6.2.1.js",
                        "~/js/portfolio-init.js",
                        "~/js/mediaelement/mediaelement.js",
                        "~/js/mediaelement/mediaelement-and-player.min.js",
                        "~/js/widget.min.js",
                        "~/js/accordion.js"
                        

                        ));
            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //           "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/rs-plugin").Include(
                      "~/rs-plugin/js/extensions/revolution.extension.actions.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.carousel.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.kenburn.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.layeranimation.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.migration.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.navigation.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.parallax.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.slideanims.min.js",
                      "~/rs-plugin/js/extensions/revolution.extension.video.min.js"

                      ));


            bundles.Add(new StyleBundle("~/css/Main").Include(
                      "~/rs-plugin/css/settings.css",
                      "~/css/icons/elegant.css",
                      "~/css/icons/icons.css",
                      "~/css/core-icons/core_style.css",
                      "~/css/scripts.css",                      
                      "~/css/style2.css"));

        }
    }
}
