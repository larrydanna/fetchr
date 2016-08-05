using System;
using web.Controllers;
using web.DataLayer.Interfaces;
using web.Entities;
using web.Enums;

namespace web.Models.Builders
{
    public class AskViewModelBuilder
    {
        public static AskIndexViewModel Build(AskViewsEnum askViewsEnum, IDataLayer<Ask> askDal)
        {
            AskIndexViewModel model = new AskIndexViewModel { Asks = askDal.Get() };

            return model;
        }
    }
}