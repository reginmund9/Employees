using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcEmployees.Models;
public class EmployeeJobTitleViewModel
{
    public List<Employee>? Employees { get; set; }
    public SelectList? JobTitles { get; set; }
    public string? JobTitle { get; set; }
    public string? SearchString { get; set; }
}





