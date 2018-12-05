using System.Collections.Generic;
using fetchr.Entities;

namespace WebServices.DataLayer.Interfaces
{
    public interface IAskDb
    {
        List<Ask> Get();
        void Save(Ask ask);
    }
}