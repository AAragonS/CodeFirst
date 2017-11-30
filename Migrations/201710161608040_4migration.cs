namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        FamilyID = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(nullable: false),
                        MLastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FamilyID);
            
            AlterColumn("dbo.People", "FamilyID", c => c.String(maxLength: 128));
            CreateIndex("dbo.People", "FamilyID");
            AddForeignKey("dbo.People", "FamilyID", "dbo.Families", "FamilyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "FamilyID", "dbo.Families");
            DropIndex("dbo.People", new[] { "FamilyID" });
            AlterColumn("dbo.People", "FamilyID", c => c.String());
            DropTable("dbo.Families");
        }
    }
}
