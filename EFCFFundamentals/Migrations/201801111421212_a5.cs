namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "Fiyat", c => c.Decimal(nullable: false, precision: 10, scale: 3));
            AlterColumn("dbo.SiparisDetaylar", "Fiyat", c => c.Decimal(nullable: false, precision: 10, scale: 4));
            AlterColumn("dbo.Siparisler", "KargoFiyati", c => c.Decimal(nullable: false, precision: 10, scale: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Siparisler", "KargoFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.SiparisDetaylar", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Urunler", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
