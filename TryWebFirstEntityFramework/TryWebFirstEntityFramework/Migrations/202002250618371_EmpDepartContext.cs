namespace TryWebFirstEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpDepartContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DId = c.Int(nullable: false),
                        DName = c.String(nullable: false),
                        DAddress = c.String(),
                    })
                .PrimaryKey(t => t.DId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EId = c.Int(nullable: false),
                        EName = c.String(nullable: false),
                        EDesignation = c.String(),
                        ESalary = c.Double(nullable: false),
                        DId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EId)
                .ForeignKey("dbo.Departments", t => t.DId, cascadeDelete: true)
                .Index(t => t.DId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
