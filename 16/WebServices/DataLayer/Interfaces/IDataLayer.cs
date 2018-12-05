using System.Collections.Generic;

namespace WebServices.DataLayer.Interfaces
{
    public interface IDataLayer<T>
    {
        IEnumerable<T> Get();
        bool Create(T t);
    }
}