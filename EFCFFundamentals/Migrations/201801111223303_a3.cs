namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tedarikciler",
                c => new
                    {
                        TedarikciId = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 100),
                        Telefon = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.TedarikciId);
            
            AddColumn("dbo.Urunler", "TedarikciId", c => c.Int());
            CreateIndex("dbo.Urunler", "TedarikciId");
            AddForeignKey("dbo.Urunler", "TedarikciId", "dbo.Tedarikciler", "TedarikciId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urunler", "TedarikciId", "dbo.Tedarikciler");
            DropIndex("dbo.Urunler", new[] { "TedarikciId" });
            DropColumn("dbo.Urunler", "TedarikciId");
            DropTable("dbo.Tedarikciler");
        }
    }
}
