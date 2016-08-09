using System;
using System.Collections.Generic;
using fetchr.Entities;
using fetchr.GenericPatterns;
using WebServices.DataLayer.Interfaces;

namespace WebServices.DataLayer
{
    public class AskDb : Singleton<AskDb, IAskDb>, IAskDb
    {
        private readonly List<Ask> _list;

        public AskDb()
        {
            _list = new List<Ask>()
            {
                new Ask()
                {
                    Description = "Scooby Snacks, Original Flavor, 48 count",
                    DateCreated = DateTime.Now.AddDays(-8)
                },
                new Ask()
                {
                    Description = "The One Ring, please hurry",
                    DateCreated = DateTime.Now.AddDays(-88)
                },
                new Ask()
                {
                    Description = "2% Milk, 1 Gal.",
                    DateCreated = DateTime.Now.AddDays(-5)
                }
            };

        }

        public bool Create(Ask ask)
        {
            bool retVal = true;

            try
            {
                _list.Add(ask);
            }
            catch (Exception)
            {
                // log ex
                retVal = false;
            }

            return retVal;
        }

        List<Ask> IAskDb.Get()
        {
            return _list;
        }

        public void Save(Ask ask)
        {
            ask.DateCreated = DateTime.UtcNow;

            _list.Add(ask);
        }
    }
}