using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore04.Medals;

internal class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<Employee> Employees { get; set; } = [];
}

