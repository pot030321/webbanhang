namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Posts", "isSale", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Posts", "isSale");
        }
    }
}
