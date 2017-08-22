namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        Password = c.String(),
                        Salt = c.String(),
                        IsLocked = c.Boolean(nullable: false),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
