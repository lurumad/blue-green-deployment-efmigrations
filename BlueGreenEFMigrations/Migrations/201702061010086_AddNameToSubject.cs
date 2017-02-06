namespace BlueGreenEFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToSubject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Subjects", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Subjects", "Name");
        }
    }
}
