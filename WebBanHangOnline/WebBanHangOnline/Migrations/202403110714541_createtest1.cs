namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtest1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Subscribe", "state");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "state", c => c.Int(nullable: false));
        }
    }
}
