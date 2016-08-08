using System.Collections.Generic;
using web.Entities;

namespace web.Models
{
    public class AskIndexViewModel : AskViewModel
    {
        public IEnumerable<Ask> Asks { get; set; }
    }
}