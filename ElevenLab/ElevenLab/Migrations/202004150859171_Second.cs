namespace ElevenLab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Histories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkerId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        WageRate = c.Int(nullable: false),
                        Status = c.String(),
                        WhyDismissal = c.String(),
                        DateOfEmployment = c.DateTime(nullable: false, storeType: "date"),
                        DateOfDismissal = c.DateTime(nullable: false, storeType: "date"),
                        OneMonthSalary = c.String(),
                        YearSalary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.PositionId, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.WorkerId)
                .Index(t => t.PositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Histories", "WorkerId", "dbo.Workers");
            DropForeignKey("dbo.Histories", "PositionId", "dbo.Positions");
            DropIndex("dbo.Histories", new[] { "PositionId" });
            DropIndex("dbo.Histories", new[] { "WorkerId" });
            DropTable("dbo.Histories");
        }
    }
}
