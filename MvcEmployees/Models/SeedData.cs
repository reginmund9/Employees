using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcEmployees.Data;  // Update the namespace for Employee model
using System;
using System.Linq;

namespace MvcEmployees.Models;  // Update the namespace to match the correct context

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcEmployeesContext(
            serviceProvider.GetRequiredService<DbContextOptions<MvcEmployeesContext>>()))
        {
            // Look for any employees.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }
            context.Employee.AddRange(
                new Employee
                {
                    Name = "John Doe",
                    HireDate = DateTime.Parse("2015-06-23"),
                    JobTitle = "Software Developer",
                    Salary = 75000M,
                    PhoneNumber = "123-456-7890"
                },
                new Employee
                {
                    Name = "Jane Smith",
                    HireDate = DateTime.Parse("2018-11-15"),
                    JobTitle = "Project Manager",
                    Salary = 90000M,
                    PhoneNumber = "987-654-3210"
                },
                new Employee
                {
                    Name = "Michael Johnson",
                    HireDate = DateTime.Parse("2020-02-01"),
                    JobTitle = "UI/UX Designer",
                    Salary = 65000M,
                    PhoneNumber = "555-234-5678"
                },
                new Employee
                {
                    Name = "Emily Davis",
                    HireDate = DateTime.Parse("2017-08-10"),
                    JobTitle = "Data Analyst",
                    Salary = 70000M,
                    PhoneNumber = "444-555-6666"
                }
            );
            context.SaveChanges();
        }
    }
}