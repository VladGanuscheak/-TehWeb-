namespace codemasters.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.UDbTables", "Confirm", c => c.String());
            //AlterColumn("dbo.UDbTables", "Password", c => c.String(maxLength: 50));
            //DropTable("dbo.PlacementDbTables");

            CreateTable(
                "dbo.UDbTables",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false),
                    Password = c.String(nullable: false),
                    Email = c.String(nullable: false),
                    LastLogin = c.DateTime(nullable: false),
                    LasIp = c.String(nullable: false),
                    Level = c.Int(nullable: true),
                    Confirm = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
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
            
            //AlterColumn("dbo.UDbTables", "Password", c => c.String(nullable: false, maxLength: 50));
            //DropColumn("dbo.UDbTables", "Confirm");
        }
    }
}
