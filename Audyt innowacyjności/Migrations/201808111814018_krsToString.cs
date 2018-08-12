namespace Audyt_innowacyjności.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class krsToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Surveys", "NumerKRS", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surveys", "NumerKRS", c => c.Int(nullable: false));
        }
    }
}
