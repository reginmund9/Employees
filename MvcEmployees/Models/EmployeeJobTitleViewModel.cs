using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcEmployees.Models;

// This is a ViewModel that is used to pass data between the controller and the view.
// It contains: list of employees and a list of job titles for filtering or selection.
public class EmployeeJobTitleViewModel
{
    // This property holds a list of employees to be displayed in the view.
    public List<Employee>? Employees { get; set; }

    // This property holds a SelectList, which is a list of job titles for dropdown selection.
    public SelectList? JobTitles { get; set; }

    // This property holds the selected job title from the user to filter the employees
    public string? JobTitle { get; set; }
    
    // This property holds the selected job title from the user to filter the employees
    public string? SearchString { get; set; }
}





