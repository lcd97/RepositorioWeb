using System.Web;
using System.Web.Optimization;

namespace RepositorioWeb {
    public class BundleConfig {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/platillaJs").Include(
                        "~/Scripts/plantilla/jquery-ui.custom.min.js",
                        "~/Scripts/plantilla/ace-elements.min.js",
                        "~/Scripts/plantilla/ace.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Scripts/font-awesome.min.css",
                      "~/Content/ace.min.css",
                      "~/Content/ace-skins.min.css",
                      "~/Content/ace-rtl.min.css"));
        }
    }
}
