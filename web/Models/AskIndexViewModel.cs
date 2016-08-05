using System.Collections.Generic;
using web.Entities;

namespace web.Models
{
    public class AskIndexViewModel
    {
        public IEnumerable<Ask> Asks { get; set; }
    }
}