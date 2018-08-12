namespace Audyt_innowacyjności.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addenum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "PraceBadawcze", c => c.Int(nullable: false));
            AddColumn("dbo.Surveys", "PerpektywaRozwoju", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "PerpektywaRozwoju");
            DropColumn("dbo.Surveys", "PraceBadawcze");
        }
    }
}
