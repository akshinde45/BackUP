namespace EntityPractMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyEntityContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        Dname = c.String(nullable: false),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Did);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Eid = c.Int(nullable: false, identity: true),
                        Ename = c.String(nullable: false),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.Eid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
