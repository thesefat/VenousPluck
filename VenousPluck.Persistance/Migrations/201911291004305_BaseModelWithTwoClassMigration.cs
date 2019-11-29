namespace VenousPluck.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BaseModelWithTwoClassMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        UserAddress = c.String(),
                        UserName = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        BloodGroup = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                        UserAddress = c.String(),
                        UserName = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        BloodGroup = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Donors");
        }
    }
}
