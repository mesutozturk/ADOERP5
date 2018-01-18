namespace AracYonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Araclar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Model = c.String(nullable: false, maxLength: 200),
                        UretimYili = c.Int(nullable: false),
                        YakitTipi = c.Short(nullable: false),
                        VitesTipi = c.Int(nullable: false),
                        Fotograf = c.Binary(),
                        MarkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markalar", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Markalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkaAdi = c.String(nullable: false, maxLength: 50),
                        KurulusYili = c.Int(nullable: false),
                        Ulke = c.String(),
                        Kurucusu = c.String(),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Araclar", "MarkaId", "dbo.Markalar");
            DropIndex("dbo.Araclar", new[] { "MarkaId" });
            DropTable("dbo.Markalar");
            DropTable("dbo.Araclar");
        }
    }
}
