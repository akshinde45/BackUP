namespace AdminLoginPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class okk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminAddBooks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Book_Name = c.String(),
                        author = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.AdminLogins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        password = c.String(),
                        LoginErrorMessage = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdminLogins");
            DropTable("dbo.AdminAddBooks");
        }
    }
}
