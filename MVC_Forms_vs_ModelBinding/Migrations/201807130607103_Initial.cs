namespace MVC_Forms_vs_ModelBinding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Houses",
                c => new
                    {
                        MyProperty = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        SquareFeet = c.String(),
                        Floors = c.Byte(nullable: false),
                        Garage = c.Boolean(nullable: false),
                        Yard = c.Boolean(nullable: false),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.MyProperty);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Houses");
        }
    }
}
