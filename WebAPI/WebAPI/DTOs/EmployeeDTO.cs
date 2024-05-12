using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebAPI.Models;

namespace WebAPI.DTOs
{
    public class EmployeeDTO
    {
        public Guid ID { get; set; }
        public double SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public string Headline { get; set; }
        public string Country { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly JoinDate { get; set; }
        public decimal FixedSalary { get; set; }
        public decimal GrossSalary { get; set; }
        public TimeOnly Arrival { get; set; }
        public TimeOnly Departure { get; set; }
        public DateOnly? LeftDate { get; set; }
        public string ShiftName { get; set; }
        public string departmentName { get; set; }
    }
}
