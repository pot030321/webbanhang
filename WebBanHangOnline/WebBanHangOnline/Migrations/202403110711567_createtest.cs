namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Subscribe", "state", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Subscribe", "state");
        }
    }
}
