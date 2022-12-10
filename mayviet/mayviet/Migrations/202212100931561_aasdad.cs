namespace mayviet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aasdad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Danhmucsanphams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Create_at = c.DateTime(),
                        Update_at = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Danhmucsanphams");
        }
    }
}
