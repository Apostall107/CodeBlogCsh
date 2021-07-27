namespace _19sqlEntityF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MinPlayersQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PlayersQuantity = c.Int(nullable: false),
                        SportID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sports", t => t.SportID, cascadeDelete: true)
                .Index(t => t.SportID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "SportID", "dbo.Sports");
            DropIndex("dbo.Teams", new[] { "SportID" });
            DropTable("dbo.Teams");
            DropTable("dbo.Sports");
        }
    }
}
