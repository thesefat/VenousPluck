namespace VenousPluck.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "Email", c => c.String());
            AddColumn("dbo.Users", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Donors", "Email");
        }
    }
}
