using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Shift
    {
        [Key]
        public int id { get; set; }
        public string exposedID { get; set; }
        public string name { get; set; }
        public TimeOnly startTime { get; set; }
        public TimeOnly endTime { get; set;}
        public DateOnly? validFrom { get; set; }
        public DateOnly? validUntil { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? lastModified { get; set; }
        [ForeignKey("CreatedBy")]
        public string createdById { get; set; }
        public virtual ApplicationUser createdBy { get; set; }
    }
}
