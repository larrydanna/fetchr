using System;
using fetchr.Entities;
using fetchr.ServiceAccess;
using web.Enums;

namespace web.Models.Builders
{
    public class AskViewModelBuilder
    {
        public static AskViewModel Build(AskViewsEnum askViewsEnum, AskServiceClient askServiceClient)
        {
            AskViewModel model = null;

            switch (askViewsEnum)
            {
                case AskViewsEnum.Index:
                    model = new AskIndexViewModel { Asks = askServiceClient.Get()};
                    break;

                case AskViewsEnum.Create:
                    model = new AskCreateViewModel
                    {
                        Title = "Throw a Bone!!",
                        Ask = new Ask() { DateCreated = DateTime.UtcNow }
                    };
                    break;
            }

            return model;
        }
    }
}