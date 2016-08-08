using System.Web.Mvc;
using web.DataLayer;
using web.DataLayer.Interfaces;
using web.Entities;
using web.Enums;
using web.Models;
using web.Models.Builders;

namespace web.Controllers
{
    public class AskController : Controller
    {
        private readonly IDataLayer<Ask> _askDal = new AskDalInMemoryList();

        public ActionResult Index()
        {
            var askIndexViewModel = (AskIndexViewModel)AskViewModelBuilder.Build(AskViewsEnum.Index, _askDal);

            return View(askIndexViewModel);
        }

        public ActionResult Create()
        {
            var askCreateViewModel = (AskCreateViewModel)AskViewModelBuilder.Build(AskViewsEnum.Create, _askDal);

            return View(askCreateViewModel);
        }

        [HttpPost]
        public ActionResult Create(AskCreateViewModel askCreateViewModel)
        {
            var askManager = new AskManager(_askDal);

            bool success = askManager.Create(askCreateViewModel.Ask);

            if (success)
            {
                return RedirectToAction("Index");
            }

            return RedirectToRoute("oops");

        }
    }

    public class AskManager
    {
        private readonly IDataLayer<Ask> _dal;

        public AskManager(IDataLayer<Ask> dal)
        {
            _dal = dal;
        }

        public bool Create(Ask ask)
        {
            return _dal.Create(ask);
        }
    }
}