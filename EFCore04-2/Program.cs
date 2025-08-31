namespace EFCore04_2;

using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using EFCore04_2.Context;

internal class Program
{
    public static async Task Main()
    {
        var context = new NorthwindContext(); //idk whyy is there an error here
        #region DB first
        //foreach (var item in context.Employees)
        //{
        //    Console.WriteLine(item.FirstName);
        //}
        #endregion

        #region Stored Procedure
        context.Procedures.TenMostExpensiveProductsAsync();

        var result = context.Procedures.SelectAllProductsAsync();

        foreach (var item in result)
        {
            Console.WriteLine(item.ProductName);
        }
        #endregion

    }
}