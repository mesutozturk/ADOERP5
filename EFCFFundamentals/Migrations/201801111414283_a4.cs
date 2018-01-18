namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SiparisDetaylar",
                c => new
                    {
                        SiparisId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Indirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.SiparisId, t.UrunId })
                .ForeignKey("dbo.Siparisler", t => t.SiparisId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.SiparisId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Siparisler",
                c => new
                    {
                        SiparisId = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(),
                        TedarikciId = c.Int(nullable: false),
                        KargoFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SiparisId)
                .ForeignKey("dbo.Tedarikciler", t => t.TedarikciId, cascadeDelete: true)
                .Index(t => t.TedarikciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylar", "UrunId", "dbo.Urunler");
            DropForeignKey("dbo.Siparisler", "TedarikciId", "dbo.Tedarikciler");
            DropForeignKey("dbo.SiparisDetaylar", "SiparisId", "dbo.Siparisler");
            DropIndex("dbo.Siparisler", new[] { "TedarikciId" });
            DropIndex("dbo.SiparisDetaylar", new[] { "UrunId" });
            DropIndex("dbo.SiparisDetaylar", new[] { "SiparisId" });
            DropTable("dbo.Siparisler");
            DropTable("dbo.SiparisDetaylar");
        }
    }
}
