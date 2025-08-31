namespace EFCore04;

using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        using var context = new Context.CompanyDbContext();
        #region Joins
        //var result = from employee in context.Employee
        //             join department in context.Department
        //             on employee.DepartmentId equals department.Id
        //             select new
        //             {
        //                 EmployeeName = employee.Name,
        //                 DepartmentName = department.Name
        //             };

        //var result = context.Department.GroupJoin(context.Employee,
        //    d => d.Id,
        //    e => e.DepartmentId,
        //    (d,e) => new
        //    {
        //        Department = d,
        //        Employee = e
        //    }).ToList();

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //context.Employee.LeftJoin();
        #endregion

        #region Mapping View
        //foreach (var item in context.EmployeeDepartmentView)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion
    }
}
