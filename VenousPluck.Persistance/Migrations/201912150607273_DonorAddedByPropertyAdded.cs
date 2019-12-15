namespace VenousPluck.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DonorAddedByPropertyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "AddedBy", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Donors", "AddedBy");
        }
    }
}
