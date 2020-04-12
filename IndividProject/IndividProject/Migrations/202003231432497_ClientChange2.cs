namespace IndividProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientChange2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "DatePas", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "DatePas", c => c.DateTime(nullable: false));
        }
    }
}
