using System.Collections.Generic;
using fetchr.Entities;

namespace web.Models
{
    public class AskIndexViewModel : AskViewModel
    {
        public IEnumerable<Ask> Asks { get; set; }
    }
}