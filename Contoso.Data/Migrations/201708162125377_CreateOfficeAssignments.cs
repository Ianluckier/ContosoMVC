namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOfficeAssignments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficeAssginments",
                c => new
                    {
                        InstructorId = c.Int(nullable: false),
                        Location = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.InstructorId)
                .ForeignKey("dbo.Instructors", t => t.InstructorId)
                .Index(t => t.InstructorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssginments", "InstructorId", "dbo.Instructors");
            DropIndex("dbo.OfficeAssginments", new[] { "InstructorId" });
            DropTable("dbo.OfficeAssginments");
        }
    }
}
