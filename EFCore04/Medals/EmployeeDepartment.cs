using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore04.Medals;

internal class EmployeeDepartment
{
    public int EmployeeId { get; set; }
    public int DepartmentId { get; set; }
    public string EmployeeName { get; set; }
    public string DepartmentName { get; set; }
}
