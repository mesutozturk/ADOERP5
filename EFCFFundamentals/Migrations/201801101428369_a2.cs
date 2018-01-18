namespace EFCFFundamentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "Stok", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "Stok");
        }
    }
}
