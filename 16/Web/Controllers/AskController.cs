using System.Web.Mvc;
using fetchr.ServiceAccess;
using web.Enums;
using web.Models;
using web.Models.Builders;

namespace web.Controllers
{
    public class AskController : Controller
    {
        public ActionResult Index()
        {
            var askIndexViewModel = (AskIndexViewModel)AskViewModelBuilder.Build(AskViewsEnum.Index, new AskServiceClient());

            return View(askIndexViewModel);
        }

        public ActionResult Create()
        {
            var askCreateViewModel = (AskCreateViewModel)AskViewModelBuilder.Build(AskViewsEnum.Create, new AskServiceClient());

            return View(askCreateViewModel);
        }

        [HttpPost]
        public ActionResult Create(AskCreateViewModel askCreateViewModel)
        {
            var askServiceClient = new AskServiceClient();

            askServiceClient.Save(askCreateViewModel.Ask);

            return RedirectToAction("Index");
        }

        public ActionResult Oops()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            return RedirectToAction("NotDone");
        }

        public ActionResult NotDone()
        {

            return View();
        }
    }
}