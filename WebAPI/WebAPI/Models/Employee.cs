using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPI.Constants;

namespace WebAPI.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string exposedId { get; set; }
        public double ssn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string headline { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        [Column(TypeName = "nvarchar(24)")]
        public Gender gender { get; set; }
        public string country { get; set; }
        public DateOnly birthDate { get; set; }
        public DateOnly joinDate { get; set; }
        public DateOnly? leftDate { get; set; }
        [Column(TypeName = "money")]
        public decimal fixedSalary { get; set; }
        [Column(TypeName = "money")]
        public decimal grossSalary { get; set; }
        [Column(TypeName = "money")]
        public decimal baseSalary { get; set; }
        [ForeignKey("department")]
        public int? deptId { get; set; }
        public  virtual Department department { get; set; }
        [ForeignKey("shift")]
        public string shiftId { get; set; }
        public virtual Shift shift { get; set; }
        public DateOnly createdAt { get; set; }
        public DateOnly? lastModified { get; set; }
        [ForeignKey("createdBy")]
        public string createdById { get; set; }
        public virtual ApplicationUser createdBy { get; set; }
    }
}
