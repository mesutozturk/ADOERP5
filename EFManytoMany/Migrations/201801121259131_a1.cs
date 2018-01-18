namespace EFManytoMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dersler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DersAdi = c.String(nullable: false, maxLength: 50),
                        Kredi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 30),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        Cinsiyet = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Ogrenci_Id = c.Int(nullable: false),
                        Ders_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_Id, t.Ders_Id })
                .ForeignKey("dbo.Ogrencis", t => t.Ogrenci_Id, cascadeDelete: true)
                .ForeignKey("dbo.Dersler", t => t.Ders_Id, cascadeDelete: true)
                .Index(t => t.Ogrenci_Id)
                .Index(t => t.Ders_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciDers", "Ders_Id", "dbo.Dersler");
            DropForeignKey("dbo.OgrenciDers", "Ogrenci_Id", "dbo.Ogrencis");
            DropIndex("dbo.OgrenciDers", new[] { "Ders_Id" });
            DropIndex("dbo.OgrenciDers", new[] { "Ogrenci_Id" });
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Dersler");
        }
    }
}
