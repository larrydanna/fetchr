using fetchr.Entities;
using fetchr.Interfaces;
using System.Web.Mvc;
using web.Enums;
using web.Models;
using web.Models.Builders;

namespace web.Controllers
{
    public class FetchController : Controller
    {
        private IRepository _repo;

        public FetchController(IRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            FetchIndexViewModel fetchIndexViewModel = FetchViewModelBuilder.Build(FetchViewsEnum.Index);

            var ask = _repo.Where<Ask>(x => x.Id == 1);



            return View(fetchIndexViewModel);
        }
    }
}