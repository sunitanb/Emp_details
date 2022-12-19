﻿namespace EmployeeAPI
{
  
        using EmployeeAPI.Context;
        using EmployeeAPI.Models;
        using System.Linq;
 

        public static class InitialData
        {
            public static void Seed(this CompanyContext dbContext)
            {
                if (!dbContext.Employees.Any())
                {
                    dbContext.Employees.Add(new Employee
                    {
                        EmployeeName = "Employee001",
                        Gender = "Male",
                        Mobile ="984331728",
                        DateOfBirth = "01-01-1990",
                        Nationality = "Indian",
                        City = "Bangalore",
                        CurrentAddress = "Current Address",
                        PermanentAddress = "Permanent Address",
                        PINCode = "560078"
                    });
                    dbContext.Employees.Add(new Employee
                    {
                        EmployeeName = "Employee002",
                        Gender = "Female",
                        Mobile = "984331728",
                        DateOfBirth = "01-01-1994",
                        Nationality = "Indian",
                        City = "Bangalore",
                        CurrentAddress = "Current Address",
                        PermanentAddress = "Permanent Address",
                        PINCode = "560078"
                    });
                    dbContext.Employees.Add(new Employee
                    {
                        EmployeeName = "Employee003",
                        Gender = "Female",
                        Mobile = "984331728",
                        DateOfBirth = "01-01-1995",
                        Nationality = "Indian",
                        City = "Bangalore",
                        CurrentAddress = "Current Address",
                        PermanentAddress = "Permanent Address",
                        PINCode = "560078"
                    });

                    dbContext.SaveChanges();
                }
            }
        }
    
}
