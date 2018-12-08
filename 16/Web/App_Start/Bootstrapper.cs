using System.Web.Mvc;
using fetchr.Interfaces;
using fetchr.Data.Providers;
using fetchr.Data;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Injection;

namespace web.App_Start
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            //This is the important line to edit  

            container.RegisterType<TestRepository>(new InjectionConstructor(new TestContext()));

            container.RegisterType<IRepository, TestRepository>();


            RegisterTypes(container);
            return container;
        }
        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}