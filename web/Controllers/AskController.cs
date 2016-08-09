using System.Web.Mvc;
using web.DataLayer;
using web.DataLayer.Interfaces;
using web.Entities;
using web.Enums;
using web.Managers;
using web.Models;
using web.Models.Builders;

namespace web.Controllers
{
    public class AskController : Controller
    {
        public IDataLayer<Ask> AskDal = new AskDalInMemoryList();

        public ActionResult Index()
        {
            var askIndexViewModel = (AskIndexViewModel)AskViewModelBuilder.Build(AskViewsEnum.Index, AskDal);

            return View(askIndexViewModel);
        }

        public ActionResult Create()
        {
            var askCreateViewModel = (AskCreateViewModel)AskViewModelBuilder.Build(AskViewsEnum.Create, AskDal);

            return View(askCreateViewModel);
        }

        [HttpPost]
        public ActionResult Create(AskCreateViewModel askCreateViewModel)
        {
            var askManager = new AskManager(AskDal);

            bool success = askManager.Create(askCreateViewModel.Ask);

            if (success)
            {
                return RedirectToAction("Index");
            }

            return RedirectToRoute("oops");

        }
    }
}