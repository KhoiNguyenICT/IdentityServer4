using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    [Table("EventTrackings")]
    public class EventTracking: BaseEntity
    {
        public string Data { get; set; }
        public string EventType { get; set; }
    }
}