using web.Entities;

namespace web.Models
{
    public class AskCreateViewModel : AskViewModel
    {
        public AskCreateViewModel()
        {
            Title = "Throw a Bone!";
        }

        public string Title { get; set; }
        public Ask Ask { get; set; }
    }
}