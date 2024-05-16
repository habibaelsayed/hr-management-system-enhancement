using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class Note
    {
        [Key]
        public int id { get; set; }
        public string exposedId { get; set; }
        public string relation { get; set; }
        public string recordId { get; set; }
        public string content { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime lastModified { get; set; }
        [ForeignKey("CreatedBy")]
        public string createdById { get; set; }
        public virtual ApplicationUser createdBy { get; set; }
    }
}