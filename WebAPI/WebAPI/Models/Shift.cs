using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Shift
    {
        [Key]
        public int ID { get; set; }
        public Guid ExposedID { get; set; }
        public string Name { get; set; }
        public DateOnly StartTime { get; set; }
        public DateOnly EndTime { get; set;}
        public DateOnly? ValidFrom { get; set; }
        public DateOnly? ValidUntil { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? LastModified { get; set; }

        // Foreign key for the ApplicationUser
        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }

        // Navigation property to refer to the ApplicationUser
        public virtual ApplicationUser CreatedBy { get; set; }


    }
}
