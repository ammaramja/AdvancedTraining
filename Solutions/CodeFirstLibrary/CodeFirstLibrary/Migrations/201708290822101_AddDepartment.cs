namespace CodeFirstLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Departments", name: "DeptName", newName: "display_name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Departments", name: "display_name", newName: "DeptName");
        }
    }
}
