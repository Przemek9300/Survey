namespace Audyt_innowacyjności.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaPrzedsiebiorstwa = c.String(),
                        IloscZmian = c.Int(nullable: false),
                        NumerRegon = c.Int(nullable: false),
                        NumerKRS = c.Int(nullable: false),
                        Miasto = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Surveys");
        }
    }
}
