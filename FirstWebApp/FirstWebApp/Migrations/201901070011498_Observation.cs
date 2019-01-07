namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Observation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Observation", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Observation");
        }
    }
}
