using EFCore04.Medals;
using Microsoft.EntityFrameworkCore;


namespace EFCore04.Context;

internal class CompanyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server= .; Database = NorthWind; Trusted_Connection = true; TrustServerCertificate = true;");
    }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<EmployeeDepartment> EmployeeDepartmentView { get; set; }
    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeDepartment>(entity =>
        {
            entity.HasNoKey().ToView("EmployeeDepartmentView");
        });
    }
}
