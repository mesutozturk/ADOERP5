namespace EFManytoMany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Ogrencis", newName: "Ogrenciler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Ogrenciler", newName: "Ogrencis");
        }
    }
}
