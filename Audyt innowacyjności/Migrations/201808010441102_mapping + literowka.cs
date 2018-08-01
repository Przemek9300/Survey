namespace Audyt_innowacyjności.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mappingliterowka : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "Konkurenci", c => c.Boolean(nullable: false));
            AddColumn("dbo.Surveys", "KonkurenciKomentarz", c => c.String());
            DropColumn("dbo.Surveys", "Konkurencji");
            DropColumn("dbo.Surveys", "KonkurencjiKomentarz");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "KonkurencjiKomentarz", c => c.String());
            AddColumn("dbo.Surveys", "Konkurencji", c => c.Boolean(nullable: false));
            DropColumn("dbo.Surveys", "KonkurenciKomentarz");
            DropColumn("dbo.Surveys", "Konkurenci");
        }
    }
}
