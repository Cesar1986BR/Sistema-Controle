using SistemaControle.Classes;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaControle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer( new  MigrateDatabaseToLatestVersion<Models.ControleContext,Migrations.Configuration>());
            this.CheckRole();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CheckRole()
        {

            Ultilidades.CheckRole("Admin");
            Ultilidades.CheckRole("Estudante");
            Ultilidades.CheckRole("Professor");

        }
    }
}
