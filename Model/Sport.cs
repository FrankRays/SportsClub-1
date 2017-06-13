using System.ComponentModel;

namespace SportsClub.Model
{
    public class Sport
    {
        public int CId { get; set; }
        [DisplayName("Continent")]
        public string ContinentName { get; set; }
        [DisplayName("Sport")]
        public string SportName { get; set; }

        public string Description { get; set; }
        [DisplayName("Image")]
        public string ImageUrl { get; set; }

    }
}
