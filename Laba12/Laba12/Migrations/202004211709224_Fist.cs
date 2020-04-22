namespace Laba12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        from = c.Int(nullable: false),
                        to = c.Int(nullable: false),
                        header = c.String(),
                        text = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
