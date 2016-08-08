using System.Collections.Generic;
using web.Entities;

namespace web.DataLayer.Interfaces
{
    public interface IDataLayer<T>
    {
        IEnumerable<T> Get();
        bool Create(T t);
    }
}