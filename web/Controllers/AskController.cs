using System.Web.Mvc;
using web.DataLayer;
using web.DataLayer.Interfaces;
using web.Entities;
using web.Enums;
using web.Models.Builders;

namespace web.Controllers
{
    public class AskController : Controller
    {
        private readonly IDataLayer<Ask> _askDal = new AskDalInMemoryList();

        public ActionResult Index()
        {
            var askIndexViewModel = AskViewModelBuilder.Build(AskViewsEnum.Index, _askDal);

            return View(askIndexViewModel);
        }

        public ActionResult Create()
        {
            throw new System.NotImplementedException();
        }
    }
}