using web.Controllers;
using web.Enums;

namespace web.Models.Builders
{
    public class FetchViewModelBuilder
    {
        public static FetchIndexViewModel Build(FetchViewsEnum fetchViewsEnum)
        {
            return new FetchIndexViewModel();
        }
    }
}