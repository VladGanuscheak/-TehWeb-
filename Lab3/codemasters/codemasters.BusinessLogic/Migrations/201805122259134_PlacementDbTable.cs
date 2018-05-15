namespace codemasters.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlacementDbTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlacementDbTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        team = c.String(nullable: false),
                        wins = c.Int(nullable: false),
                        draws = c.Int(nullable: false),
                        loses = c.Int(nullable: false),
                        gols_scored = c.Int(nullable: false),
                        gols_received = c.Int(nullable: false),
                        points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PlacementDbTables");
        }
    }
}
