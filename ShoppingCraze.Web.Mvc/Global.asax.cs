using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ShoppingCraze.Infrastructure;
using ShoppingCraze.Service;
using ShoppingCraze.Service.Interfaces;
using ShoppingCraze.Web.Mvc.Models;
using Unity;
using Unity.AspNet.Mvc;

namespace ShoppingCraze.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            IUnityContainer container = new UnityContainer();
            //container.RegisterSingleton<IStudentRepository, StudentRepository>();
            container.RegisterType<DbContext, ShoppingCrazeDbContext>();
            container.RegisterType<ICourseService, CourseSevice>();
            container.RegisterType<ISectionService, SectionSevice>();
            container.RegisterType<IStudentService, StudentSevice>();
            container.RegisterType<IRegistrationService, RegistrationSevice>();
            UnityDependencyResolver unityResolver = new UnityDependencyResolver(container);
            DependencyResolver.SetResolver(unityResolver);

            //new RegistrationController(new RegistrationService(new UmsDbContext()));
            //new StudentController(new StudentService(new UmsDbContext()));
            //new CourseController(new CourseService(new UmsDbContext()));

            StyleBundle stb = new StyleBundle("~/MyStyles");
            stb.Include("~/Content/Site.css");
            stb.Include("~/Content/bootstrap.css");

            ScriptBundle scb = new ScriptBundle("~/MyScripts");
            scb.Include("~/Scripts/Site.js");
            scb.Include("~/Scripts/bootstrap.js");

            BundleTable.Bundles.Add(stb);
            BundleTable.Bundles.Add(scb);

            BundleTable.EnableOptimizations = true;
        }

        protected void Session_Start()
        {
            Session["cart"] = new List<OrderVM>();
        }
    }
}
