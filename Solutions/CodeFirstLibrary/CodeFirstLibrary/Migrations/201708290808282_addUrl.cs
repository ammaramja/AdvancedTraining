namespace CodeFirstLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "addUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "addUrl");
        }
    }
}
