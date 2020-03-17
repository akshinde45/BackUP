namespace StudEntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        SName = c.String(nullable: false),
                        Sfees = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
