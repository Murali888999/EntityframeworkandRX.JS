namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createemp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.emps",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.emps");
        }
    }
}
