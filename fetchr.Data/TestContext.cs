using fetchr.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace fetchr.Data
{


    public class TestContext 
    {
        public List<Ask> Asks { get; set; }

        public List<T> Set<T>() where T : class
        {
            return GetSet<T>();
        }

        private List<T> GetSet<T>() where T : class
        {
            var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var p in properties)
            {
                var found = p.PropertyType.GetGenericArguments().SingleOrDefault(x => x.Name == typeof(T).Name);

                if (found != null)
                {
                    return (List<T>)p.GetValue(this);
                }
            }
            return null;
        }

        public TestContext()
        {
            Asks = new List<Ask>();

            Asks.AddRange(new List<Ask>()
                {
                    new Ask()
                    {
                        Id = 1,
                        Description = "Scooby Snacks, Original Flavor, 48 count",
                        DateCreated = DateTime.Now.AddDays(-8)
                    },
                    new Ask()
                    {
                        Id = 2,
                        Description = "The One Ring, please hurry",
                        DateCreated = DateTime.Now.AddDays(-88)
                    },
                    new Ask()
                    {
                        Id = 3,
                        Description = "2% Milk, 1 Gal.",
                        DateCreated = DateTime.Now.AddDays(-5)
                    }
                });
        }

    }

    }
