using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcEmployees.Models;

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
    
    
    [Column(TypeName = "decimal(18, 2)")]
    [Required]
    public decimal Salary { get; set; }

    [Display(Name = "Phone Number")]
    [DataType(DataType.PhoneNumber)]
    [Required]
    public string? PhoneNumber { get; set; }
}
