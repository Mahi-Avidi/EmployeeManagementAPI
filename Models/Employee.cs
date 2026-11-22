using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        [Range(0.01, 999999999)]
        public decimal Salary { get; set; }
    }
}