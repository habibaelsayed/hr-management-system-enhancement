using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebAPI.Constants;
using WebAPI.Models;

namespace WebAPI.DTOs
{
    public class EmployeeDto
    {
        public string id { get; set; }
        public double ssn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public Gender gender { get; set; }
        public string headline { get; set; }
        public string country { get; set; }
        public DateOnly birthDate { get; set; }
        public DateOnly joinDate { get; set; }
        public DateOnly? leftDate { get; set; }
        public decimal fixedSalary { get; set; }
        public decimal grossSalary { get; set; }
        public decimal baseSalary { get; set; }
        public ShiftDTO shiftDTO { get; set; }
        public DepartmentDTO departmentDTO { get; set; }
        public DateOnly createdAt { get; set; }
        public DateOnly? lastModified { get; set; }
        public UserDTO createdBy { get; set; }
    }
}
