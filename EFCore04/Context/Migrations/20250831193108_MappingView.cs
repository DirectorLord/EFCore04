using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore04.Context.Migrations
{
    /// <inheritdoc />
    public partial class MappingView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create View EmployeeDepartmentView 
            as
            select E.Id as EmployyeeId, E.Name as EmployeeName, D.Id as DepartmentId, D.Name as DepartmentName
            from Employee E join Department D
            on E.DepartmentId = D.Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View EmployeeDepartmentView");
        }
    }
}
