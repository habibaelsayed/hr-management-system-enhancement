

using WebAPI.Models;

namespace WebAPI.DTOs
{
    public class ShiftDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public TimeOnly startTime { get; set; }
        public TimeOnly endTime { get; set; }
        public DateOnly? validFrom { get; set; }
        public DateOnly? validUntil { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? lastModified { get; set; }
        public UserDTO createdBy { get; set; }
    }
}
