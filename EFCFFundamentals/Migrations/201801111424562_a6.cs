namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SiparisDetaylar", "Indirim", c => c.Decimal(nullable: false, precision: 5, scale: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SiparisDetaylar", "Indirim", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
