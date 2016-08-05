using System;
using System.Collections.Generic;
using web.DataLayer.Interfaces;
using web.Entities;

namespace web.DataLayer
{
    public class AskDalInMemoryList : IDataLayer<Ask>
    {
        private readonly List<Ask> _list;

        public AskDalInMemoryList()
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
                    DateCreated = DateTime.Now.AddDays(-8)
                },
                new Ask()
                {
                    Description = "2% Milk, 1 Gal.",
                    DateCreated = DateTime.Now.AddDays(-5)
                }
            };

        }

        public IEnumerable<Ask> Get()
        {
            return _list;
        }
    }
}