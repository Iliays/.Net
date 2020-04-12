namespace IndividProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateChangeOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "DateGive", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Orders", "DateTake", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "DateTake", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "DateGive", c => c.DateTime(nullable: false));
        }
    }
}
