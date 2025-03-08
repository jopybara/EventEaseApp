using System.ComponentModel.DataAnnotations;

namespace EventEaseApp.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Organizer { get; set; }
        public List<Participant> Participants { get; set; } = [];
    }
}
