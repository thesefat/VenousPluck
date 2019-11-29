namespace VenousPluck.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImagePropertyAddedToModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "Image", c => c.String());
            AddColumn("dbo.Users", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Image");
            DropColumn("dbo.Donors", "Image");
        }
    }
}
