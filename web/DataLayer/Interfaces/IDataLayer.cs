using System.Collections.Generic;

namespace web.DataLayer.Interfaces
{
    public interface IDataLayer<T>
    {
        IEnumerable<T> Get();
    }
}