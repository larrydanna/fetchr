using System;
using web.Controllers;
using web.DataLayer.Interfaces;
using web.Entities;
using web.Enums;

namespace web.Models.Builders
{
    public class AskViewModelBuilder
    {
        public static AskViewModel Build(AskViewsEnum askViewsEnum, IDataLayer<Ask> askDal)
        {
            AskViewModel model = null;

            switch (askViewsEnum)
            {
                case AskViewsEnum.Index:
                    model = new AskIndexViewModel { Asks = askDal.Get() };
                    break;

                case AskViewsEnum.Create:
                    model = new AskCreateViewModel { Title = "Throw a Bone!!" };
                    break;
            }

            return model;
        }
    }
}