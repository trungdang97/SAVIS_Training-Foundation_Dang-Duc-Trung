namespace Using_Web_API_2_with_Entity_Framework_6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        strName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        strTitle = c.String(nullable: false),
                        intYear = c.Int(nullable: false),
                        decPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        strGenre = c.String(),
                        intAuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.intAuthorId, cascadeDelete: true)
                .Index(t => t.intAuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "intAuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "intAuthorId" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
