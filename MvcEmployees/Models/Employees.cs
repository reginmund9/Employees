using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcEmployees.Models;

// This is the Employee model class which represents the employee's data with various properties such as Name, HireDate, JobTitle, etc.
public class Employee
{
    public int Id { get; set; }

    [Required]
    public string? Name { get; set; }
        
    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    [Required]
    public DateTime HireDate { get; set; }

    [Display(Name = "Job Title")]
    [Required]
    public string? JobTitle { get; set; }
    
    [Display(Name = "Salary per Month")]
    [Column(TypeName = "decimal(18, 2)")]
    [Required]
    public decimal Salary { get; set; }

    [Display(Name = "Phone Number")]
    [DataType(DataType.PhoneNumber)]
    [Required]
    public string? PhoneNumber { get; set; }
}
