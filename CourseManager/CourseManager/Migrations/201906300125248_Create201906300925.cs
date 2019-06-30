namespace CourseManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create201906300925 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SideBars", "order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SideBars", "order");
        }
    }
}
