namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "FamilyID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "FamilyID");
        }
    }
}
