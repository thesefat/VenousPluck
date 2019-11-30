namespace VenousPluck.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressPropertyExcluded : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Donors", "UserAddress");
            DropColumn("dbo.Users", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Address", c => c.String());
            AddColumn("dbo.Donors", "UserAddress", c => c.String());
        }
    }
}
