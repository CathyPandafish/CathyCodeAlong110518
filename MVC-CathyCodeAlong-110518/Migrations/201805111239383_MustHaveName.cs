namespace MVC_CathyCodeAlong_110518.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MustHaveName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
        }
    }
}
