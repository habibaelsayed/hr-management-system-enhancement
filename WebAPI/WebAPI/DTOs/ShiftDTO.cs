

namespace WebAPI.DTOs
{
    public class ShiftDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateOnly StartTime { get; set; }
        public DateOnly EndTime { get; set; }
        public DateOnly? ValidFrom { get; set; }
        public DateOnly? ValidUntil { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        public string CreatedById { get; set; }
    }
}
