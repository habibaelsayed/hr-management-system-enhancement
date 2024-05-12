using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Constants;

namespace WebAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public Guid ExposedID { get; set; }

        public double SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Headline { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly JoinDate { get; set; }

        [Column(TypeName = "money")]
        public decimal FixedSalary { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossSalary { get; set; }
        public TimeOnly Arrival { get; set; }
        public TimeOnly Departure { get; set; }

        [ForeignKey("Department")]
        public int? DeptId { get; set; }

        // Navigation Properties
        public  virtual Department Department { get; set; }

        [ForeignKey("Shift")]
        public string ShiftId { get; set; }
        public virtual Shift Shift { get; set; }

        public DateOnly? LeftDate { get; set; }


    }
}
