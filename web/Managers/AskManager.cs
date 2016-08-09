using web.DataLayer.Interfaces;
using web.Entities;

namespace web.Managers
{
    public class AskManager
    {
        private readonly IDataLayer<Ask> _dal;

        public AskManager(IDataLayer<Ask> dal)
        {
            _dal = dal;
        }

        public bool Create(Ask ask)
        {
            return _dal.Create(ask);
        }
    }
}