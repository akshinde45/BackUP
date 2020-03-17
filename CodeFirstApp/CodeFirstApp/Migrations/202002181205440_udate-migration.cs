namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class udatemigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        productID = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.products");
        }
    }
}
