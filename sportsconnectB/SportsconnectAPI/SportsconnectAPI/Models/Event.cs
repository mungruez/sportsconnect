namespace SportsconnectAPI.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public int duration { get; set; }
        public string sport { get; set; }
        public string owner { get; set; }
        public string location { get; set; }
        public DateTime startDate { get; set; }
        public string playersAttending { get; set; }
        public int pCode { get; set; }
    }
}
