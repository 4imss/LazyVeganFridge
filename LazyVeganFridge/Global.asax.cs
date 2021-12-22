using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LazyVeganFridge.Migrations;
using LazyVeganFridge.Models;

namespace LazyVeganFridge
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            //Database.SetInitializer<ApplicationDbContext>(null);
            //Database.Delete("ApplicationDbContext");
            //ApplicationDbContext dbContext = new ApplicationDbContext();

            //dbContext.Database.Delete();
            DbMigrator dbMigrator = new DbMigrator(new Configuration());

            dbMigrator.Update();
        }
    }
}
