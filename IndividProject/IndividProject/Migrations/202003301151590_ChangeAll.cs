namespace IndividProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeAll : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "DiscriptionOrder", c => c.String(nullable: false));
            AlterColumn("dbo.Clients", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Login", c => c.String());
            AlterColumn("dbo.Clients", "Surname", c => c.String());
            AlterColumn("dbo.Orders", "DiscriptionOrder", c => c.String());
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
