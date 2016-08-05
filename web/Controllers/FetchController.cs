using System.IO;
using System.Web.Mvc;
using web.Enums;
using web.Models;
using web.Models.Builders;

namespace web.Controllers
{
    public class FetchController : Controller
    {
        public ActionResult Index()
        {
            FetchIndexViewModel fetchIndexViewModel = FetchViewModelBuilder.Build(FetchViewsEnum.Index);

            return View(fetchIndexViewModel);
        }
    }
}