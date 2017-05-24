namespace AzureSqlDatabaseConnectWithMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "Credit", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Credit", c => c.String());
            AlterColumn("dbo.Courses", "Code", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
        }
    }
}
