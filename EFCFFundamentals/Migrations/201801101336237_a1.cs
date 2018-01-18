namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAdı = c.String(name: "Kategori Adı", nullable: false, maxLength: 25, unicode: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 40),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EklenmeZamani = c.DateTime(nullable: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.UrunAdi, unique: true)
                .Index(t => t.KategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "KategoriId", "dbo.Kategoriler");
            DropIndex("dbo.Urunler", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "UrunAdi" });
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
