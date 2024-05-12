using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Note
    {
        [Key]
        public int ID { get; set; }
        public Guid ExposedID { get; set; }
        public string Relation { get; set; }
        public string RecordID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModified { get; set; }

        // TODO: change this to User instead of ApplicationUser in the future

        // Foreign key for the ApplicationUser
        [ForeignKey("CreatedBy")]
        public string CreatedById { get; set; }

        // Navigation property to refer to the ApplicationUser
        public virtual ApplicationUser CreatedBy { get; set; }
    }
}