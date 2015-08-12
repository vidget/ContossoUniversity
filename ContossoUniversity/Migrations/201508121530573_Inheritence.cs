namespace ContossoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inheritence : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Person", newName: "Student");
            AlterColumn("dbo.Student", "EnrollmentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "EnrollmentDate", c => c.DateTime());
            RenameTable(name: "dbo.Student", newName: "Person");
        }
    }
}
