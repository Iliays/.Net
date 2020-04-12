namespace IndividProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeClient : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Number", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "Seria", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "Seria", c => c.String());
            AlterColumn("dbo.Clients", "Number", c => c.String());
        }
    }
}
